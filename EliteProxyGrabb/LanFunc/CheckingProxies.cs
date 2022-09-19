using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteProxyGrabb.LanFunc
{
    public partial class CheckingProxies : UserControl
    {
        public event EventHandler Checked;
        private List<IFinder> Finders = new List<IFinder>();
        public ProxyList ProxyList { get; set; }
        public ProxyCompliteList ProxyCompliteList { get; set; }
        public bool IsChecking { get; private set; }
        public ThreadBindingList<Proxy> NewProxy = new ThreadBindingList<Proxy>();
        public ThreadBindingList<Proxy> BadProxy = new ThreadBindingList<Proxy>();
        public ThreadBindingList<Proxy> Working = new ThreadBindingList<Proxy>();
        public int CountNewProxies { get; private set; } = 0;
        HtmlWeb web = new HtmlWeb();
        public CheckingProxies()
        {
            InitializeComponent();
        }


        public void SetInterval(int refinding = 900, int checkingnewproxy = 350)
        {
            timer.Interval = refinding;
            timerCheckActuality.Interval = checkingnewproxy;
        }

        public void Start()
        {
            timer.Enabled = timerCheckActuality.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = timerCheckActuality.Enabled = false;
        }

        public void Add(IFinder finder)
        {
            Finders.Add(finder);
            finder.Finding += FinderOnFinding;
        }

        private void FinderOnFinding(IFinder sender, List<Proxy> newproxylist)
        {
            var a = new Action(() =>
            {
                lnew.Text = NewProxy.Count.ToString();
                lnew.Invalidate();
            });
            foreach (Proxy proxy in newproxylist)
            {
                if (NewProxy.FirstOrDefault(p => p.Ip == proxy.Ip && p.Port == proxy.Port) == null 
                    && BadProxy.FirstOrDefault(p => p.Ip == proxy.Ip && p.Port == proxy.Port)==null)
                {
                    NewProxy.Add(proxy);
                    if (lnew.InvokeRequired) lnew.Invoke(a);
                    else a.Invoke();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private async void timer_Tick(object sender, System.EventArgs e)
        {
            if (Finders.Count == 0 || IsChecking) return;
            IsChecking = true;

            var finders = Finders.Where(f => f.NeedCheck);
            foreach (IFinder finder in finders)
            {
                var result = await finder.Grab();
                var newproxy = DropFromCopy(result);
                foreach (Proxy proxy in newproxy)
                    NewProxy.Add(proxy);
                CountNewProxies += newproxy.Count;
                finder.LastCheck = DateTime.Now;
            }
            IsChecking = false;
        }

        private List<Proxy> DropFromCopy(Proxy[] result)
        {
            List<Proxy> ret = new List<Proxy>();
            foreach (Proxy proxy in ret)
            {
                if(proxy.Protocol==null) continue;
                if (ProxyList.Contains(proxy)) continue;
                if (ProxyCompliteList.Contains(proxy)) continue;
                ret.Add(proxy);
            }
            return ret;
        }


        private async void timerCheckActuality_Tick(object sender, System.EventArgs e)
        {
            if (NewProxy.Count == 0) return;
            // послать на проверку (асихнронная проверка)
            Check(NewProxy[0]);
            // удалить из списка новых
            NewProxy.RemoveAt(0);
            lnew.Text = NewProxy.Count.ToString();
        }

        private bool isTest = false;
        public async Task Check(Proxy p)
        {
            if (p == null || isTest || p.Protocol==null){isTest = false;return;}
            isTest = true;
            string protool = p.Protocol?.ToLower()?.Trim();
            try
            {
                if (protool.StartsWith("http"))
                {
                    var http = new HtmlAgilityPack.HtmlDocument();
                    MyWebClient wc = new MyWebClient
                    {
                        Proxy = new WebProxy
                        {
                            Address = new Uri(p.Protocol+"://"+p.Ip + ":" + p.Port)
                        }
                    };
                    var html = await wc.DownloadStringTaskAsync("https://www.babaip.com/");
                    http.LoadHtml(html);
                    var txt = http.DocumentNode.SelectNodes("//b").First().InnerHtml
                        .Replace("<br>","\n")
                        .Replace("</br>","\n")
                        .Replace("&#69;","E")
                        .Split('\n')
                        .Where(s=>!string.IsNullOrWhiteSpace(s))
                        .Select(s=>s.Contains("<")?s.Substring(0,s.IndexOf("<", StringComparison.Ordinal)):s)
                        .ToArray();
                    p.Country = txt?.FirstOrDefault(s => s.StartsWith("Country Code"))?.Split(':')?.Last()?.Trim();
                    p.HostName = txt?.FirstOrDefault(s => s.StartsWith("Hostname"))?.Split(':')?.Last()?.Trim();
                    p.LastCheckData = DateTime.Now.ToString("u");
                    p.Level= txt?.FirstOrDefault(s => s.StartsWith("Proxy Anonymity Level"))?.Split(':')?.Last()?.Trim();
                }
                else
                if (protool.StartsWith("socks"))
                {
                    var proxy = new WebProxy();
                    proxy.Address = new Uri(p.Protocol + "://" + p.Ip + ":" + p.Port);
                    var handler = new HttpClientHandler { Proxy = proxy };
                    var httpClient = new HttpClient(handler);
                    var html = await httpClient.GetStringAsync("https://www.babaip.com/");
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var tmp = doc.DocumentNode.InnerText;
                    ;
                }
                Working.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                BadProxy.Add(p);
            }
            Checked?.Invoke(this,null);
            lall.Invoke(new Action((() => lall.Text = (int.Parse(lall.Text) + 1).ToString())));
            isTest = false;
        }
    }

    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 10000;
            return w;
        }
    }
}

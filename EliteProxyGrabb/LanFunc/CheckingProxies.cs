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
        private List<IFinder> Finders = new List<IFinder>();
        public ProxyList ProxyList { get; set; }
        public ProxyCompliteList ProxyCompliteList { get; set; }
        public bool IsChecking { get; private set; }
        public ThreadBindingList<Proxy> NewProxy = new ThreadBindingList<Proxy>();
        public int CountNewProxies { get; private set; } = 0;
        HtmlWeb web = new HtmlWeb();
        public CheckingProxies()
        {
            InitializeComponent();

        }

        public void SetInterval(int refinding = 900, int checkingnewproxy = 3500)
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
                if (NewProxy.FirstOrDefault(p => p.Ip == proxy.Ip && p.Port == proxy.Port) == null)
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
            }
            IsChecking = false;
        }

        private List<Proxy> DropFromCopy(Proxy[] result)
        {
            List<Proxy> ret = new List<Proxy>();
            foreach (Proxy proxy in ret)
            {
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
        }

        public async Task Check(Proxy p)
        {
            if (p == null) return;
            string protool = p.Protocol?.ToLower()?.Trim();
            try
            {
                if (protool.StartsWith("http"))
                {
                    var http = new HtmlAgilityPack.HtmlDocument();
                    WebClient wc = new WebClient
                    {
                        Proxy = new WebProxy
                        {
                            Address = new Uri(p.Protocol+"://"+p.Ip + ":" + p.Port)
                        }
                    };
                    var html = await wc.DownloadStringTaskAsync("https://www.babaip.com/");
                    http.LoadHtml(html);
                    var ret = http.DocumentNode.InnerText;
                    ;
                }

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
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

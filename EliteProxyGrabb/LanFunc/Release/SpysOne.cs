using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class SpysOne : Finder
    {
        public override async Task<Proxy[]> Grab()
        {
            var web = new HtmlWeb();
            var doc = web.LoadFromBrowser("https://spys.one/proxies/");
            var tr = doc.GetElementsByTagName("tr")?.Skip(7)?.ToList();
            List<Proxy> ret = new List<Proxy>();
            foreach (HtmlNode node in tr)
            {
                if (node.ChildNodes.Count <3 || !char.IsDigit(node.ChildNodes[1].InnerText[0])) continue;
                try
                {
                    var p = new Proxy
                    {
                        Ip = node.ChildNodes[1].InnerText.Split('\r').First(),
                        Port = node.ChildNodes[1].InnerText.Split(':').Last(),
                        Protocol = node.ChildNodes[3].InnerText.Split(' ').First(),
                    };
                    ret.Add(p);
                }
                catch
                {

                }
            }
            OnFinding(ret);
            await Task.Delay(2024);
            return ret.ToArray();
        }
    }
}

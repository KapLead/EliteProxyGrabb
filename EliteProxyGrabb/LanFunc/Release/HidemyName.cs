using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class HidemyName : Finder
    {
        public override async Task<Proxy[]> Grab()
        {
            var web = new HtmlWeb();
            var doc = web.LoadFromBrowser("https://hidemy.name/ru/proxy-list/?type=hs&anon=4#list");
            var tr = doc.GetElementsByTagName("tr").Skip(1).ToList();
            List<Proxy> ret = new List<Proxy>();
            foreach (HtmlNode node in tr)
            {
                try
                {
                    if (node.ChildNodes.Count < 9 || !char.IsDigit(node.ChildNodes[1].InnerText[0])) continue;
                    var p = new Proxy
                    {
                        Ip = node.ChildNodes[1].InnerText,
                        Port = node.ChildNodes[3].InnerText,
                        Protocol = node.ChildNodes[9].InnerText,
                    };
                    ret.Add(p);
                }
                catch { }
            }
            OnFinding(ret);
            await Task.Delay(2024);
            return ret.ToArray();
        }
    }
}

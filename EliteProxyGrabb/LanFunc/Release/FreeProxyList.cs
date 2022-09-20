using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class FreeProxyList : Finder
    {
        public override async Task<Proxy[]> Grab()
        {
            List<Proxy> ret = new List<Proxy>();
            var web = new HtmlWeb();
            for (int i = 1; i < 5; i++)
            {
                var doc = web.LoadFromBrowser($"https://freeproxylist.ru/proxy-list?page={i}");
                var tr = doc.GetElementsByTagName("tr").Skip(2).ToList();
                foreach (HtmlNode node in tr)
                {
                    try
                    {
                        if (node.ChildNodes.Count < 9 || !char.IsDigit(node.ChildNodes[1].InnerText[0])) 
                            continue;
                        var p = new Proxy
                        {
                            Ip = node.ChildNodes[1].InnerText,
                            Port = node.ChildNodes[3].InnerText,
                            Protocol = node.ChildNodes[7].InnerText,
                        };
                        ret.Add(p);
                    }
                    catch { }
                }
                OnFinding(ret);
            }
            await Task.Delay(2024);
            return ret.ToArray();
        }
    }
}

using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc.Release
{
    public class Openproxyspace : Finder
    {
        public override string Host => "https://www.sslproxies.org/";

        public override async Task<Proxy[]> Grab()
        {
            List<Proxy> ret = new List<Proxy>();
            var web = new HtmlWeb();
            for (int i = 1; i < 5; i++)
            {
                var doc = web.LoadFromBrowser($"{Host}");
                var tr = doc.GetElementsByTagName("tr").Skip(1).ToList();
                foreach (HtmlNode node in tr)
                {
                    try
                    {
                        if (node.ChildNodes.Count < 8 || !char.IsDigit(node.ChildNodes[0].InnerText[0]) || node.ChildNodes[0].InnerText.Count(c => c == '.') !=3)
                            continue;
                        var p = new Proxy
                        {
                            Ip = node.ChildNodes[0].InnerText,
                            Port = node.ChildNodes[1].InnerText,
                            Protocol = "https",
                        };
                        if (p?.Ip?.Count(c => c == '.') == 3)
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

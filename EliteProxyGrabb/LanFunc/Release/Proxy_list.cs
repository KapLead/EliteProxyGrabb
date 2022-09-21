using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace EliteProxyGrabb.LanFunc.Release
{
    public class Proxy_list : Finder
    {
        public override string Host => "https://proxy-list.org/";

        public override async Task<Proxy[]> Grab()
        {
            List<Proxy> ret = new List<Proxy>();
            var web = new HtmlWeb();
            for (int i = 1; i < 5; i++)
            {
                var doc = web.LoadFromBrowser($"{Host}russian/search.php?search=elite&country=any&type=elite&port=any&ssl=any&p={i}");
                var tr = doc.GetElementsByTagName("ul").Skip(3).ToList();
                foreach (HtmlNode node in tr)
                {
                    try
                    {
                        if (node.ChildNodes.Count < 9 || !char.IsDigit(node.ChildNodes[1].InnerText.Replace("\r\n",null)[0]) || node.ChildNodes[1].InnerText.Replace("\r\n", null).Count(c => c == '*') >0)
                            continue;
                        var p = new Proxy
                        {
                            Ip = node.ChildNodes[1].InnerText.Replace("\r\n", null).Split(':').First(),
                            Port = node.ChildNodes[1].InnerText.Replace("\r\n", null).Split(':').Last(),
                            Protocol = node.ChildNodes[3].InnerText.ToLower().Trim(),
                        };
                        if (p?.Ip?.Count(c => c == '.') == 3)
                            ret.Add(p);
                    }
                    catch { }
                }
                OnFinding(ret);
                if (tr.Count == 11) break;
            }
            await Task.Delay(2024);
            return ret.ToArray();
        }
    }
}

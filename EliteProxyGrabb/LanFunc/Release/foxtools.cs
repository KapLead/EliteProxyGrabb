using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace EliteProxyGrabb.LanFunc.Release
{
    public class Foxtools : Finder
    {
        public override string Host => "http://foxtools.ru/";

        public override async Task<Proxy[]> Grab()
        {
            List<Proxy> ret = new List<Proxy>();
            var web = new HtmlWeb();
            for (int i = 1; i < 5; i++)
            {
                var doc = web.LoadFromBrowser($"{Host}Proxy?al=False&am=False&ah=False&ahs=True&http=True&https=True&page={i}");
                var tr = doc.GetElementsByTagName("tr").Skip(2).ToList();
                foreach (HtmlNode node in tr)
                {
                    try
                    {
                        if (node.ChildNodes.Count < 12 || !char.IsDigit(node.ChildNodes[3].InnerText[0]) || node.ChildNodes[3].InnerText.Count(c => c == '.') != 3)
                            continue;
                        var p = new Proxy
                        {
                            Ip = node.ChildNodes[3].InnerText,
                            Port = node.ChildNodes[5].InnerText,
                            Protocol = node.ChildNodes[11].InnerText.ToLower().Trim(),
                        };
                        if (p?.Ip?.Count(c => c == '.') == 3)
                            ret.Add(p);
                    }
                    catch { }
                }
                OnFinding(ret);
                if(tr.Count==0) break;
            }
            await Task.Delay(2024);
            return ret.ToArray();
        }
    }
}

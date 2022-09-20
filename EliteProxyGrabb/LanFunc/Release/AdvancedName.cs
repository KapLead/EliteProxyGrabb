using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class AdvancedName : Finder
    {
        public override async Task<Proxy[]> Grab()
        {
            List<Proxy> ret = new List<Proxy>();
            var web = new HtmlWeb();
            string[] variable = new[]
            {
                "elite", "anon", 
                // "socks4", "socks5"

            };
            foreach (string s in variable)
                for (int i = 1; i < 12; i++)
                {
                    var doc = web.LoadFromBrowser($"https://advanced.name/ru/freeproxy?type={s}&page={i}");
                    var tr = doc.GetElementsByTagName("tr").Skip(1).ToList();
                    foreach (HtmlNode node in tr)
                    {
                        try
                        {
                            if (node.ChildNodes.Count < 9 && !char.IsDigit(node.ChildNodes[3].InnerText[0])) continue;
                            var p = new Proxy
                            {

                                Ip = node.ChildNodes[3].InnerText,
                                Port = node.ChildNodes[5].InnerText,
                                Protocol = node.ChildNodes[7].InnerText.Split(' ').First(),
                            };
                            ret.Add(p);  
                        }
                        catch { }
                    }
                    if (ret.Count == 0) break;
                    OnFinding(ret);
                }
            await Task.Delay(2024);
            return ret.ToArray();
        }

    }
}

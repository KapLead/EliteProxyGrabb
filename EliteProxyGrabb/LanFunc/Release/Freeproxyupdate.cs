using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteProxyGrabb.LanFunc
{
    public class FreeProxyUpdate : Finder
    {
        public override string Host => "https://freeproxyupdate.com/";

        public FreeProxyUpdate()
        {
        }


        public override async Task<Proxy[]> Grab()
        {
            var Urls = new[]
            {
                "united-states-us",
                "russia-ru",
                "china-cn",
                "united-kingdom-uk",
                "france-fr",
                "germany-de",
                "india-in",
                "pakistan-pk",
                "iran-ir",
                "iraq-iq",
                "bangladesh-bd",
                "indonesia-id",
                "nigeria-ng",
                "brazil-br",
                "egypt-eg",
                "turkey-tr",
            };
            List<Proxy> ret = new List<Proxy>();
            List<Proxy> tmp = new List<Proxy>();
            string[] types = new[] { "/anonymous", "/elite" };
            var web = new HtmlWeb();
            foreach (string type in types)
            {
                foreach (string url in Urls)
                {
                    try
                    {
                        var doc = await web.LoadFromWebAsync(Host+ url + type);
                        var tr = doc.GetElementsByTagName("tr").Skip(7).ToList();
                        foreach (HtmlNode node in tr)
                        {
                            var dat = ToProxy(node.InnerText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray());
                            if (dat != null && dat.Ip.Count(c=>c=='.')==3)
                                tmp.Add(dat);
                        }
                        OnFinding(tmp);
                        await Task.Delay(2024);
                    }
                    catch
                    {
                    }
                }
                ret.AddRange(tmp);
            }
            return ret.ToArray();
        }

        private Proxy ToProxy(string[] arr)
        {
            Proxy ret = new Proxy();
            if (arr.Length == 11)
            {
                ret.Ip = arr[0];
                ret.Port = arr[1];
                ret.Protocol = arr[4];
            }
            return ret;
        }
    }
}

using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace EliteProxyGrabb.LanFunc
{
    public static class ExAgilityPack
    {
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlDocument parent, string name)
        {
            return parent.DocumentNode.Descendants().Where(node => node.Name == name);

        }

        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlDocument parent, string name)
        {
            return parent.DocumentNode.Descendants(name);
        }
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string name)
        {
            return parent.Descendants().Where(node => node.Name == name);
        }

        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlNode parent, string name)
        {
            return parent.Descendants(name);
        }
    }
}

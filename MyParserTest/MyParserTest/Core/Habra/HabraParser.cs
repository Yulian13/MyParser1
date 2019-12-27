using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTest.Core.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parser(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray()  ;
        }
    }
}

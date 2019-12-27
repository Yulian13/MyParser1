using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace MyParserTest.Core
{
    interface IParser<T> where T : class
    {
        T Parser(IHtmlDocument document);
    }
}

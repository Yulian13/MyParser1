using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace ParserTest.Core
{
    interface IParser<T> where T : class
    {
        T Parser(IHtmlDocument document);
    }
}

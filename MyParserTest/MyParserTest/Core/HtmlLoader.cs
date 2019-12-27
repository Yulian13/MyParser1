using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyParserTest.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            this.client = new HttpClient();
            this.url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}",id.ToString());
            var response = await client.GetAsync(currentUrl);
            string sourse = null;


            if(response != null & response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }

            return sourse;
        }
    }
}

﻿using System.Net;
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

        public async Task<string> GetSourceByPageId()
        {
            var response = await client.GetAsync(url);
            string sourse = null;


            if(response != null & response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }

            return sourse;
        }
    }
}

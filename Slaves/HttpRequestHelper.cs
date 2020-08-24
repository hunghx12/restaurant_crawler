using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avengers.Slaves
{
    public class HttpRequestHelper
    {
        private static HttpRequestHelper instance;
        private HttpRequestHelper()
        {
        }
        public static HttpRequestHelper GetIntance()
        {
            if (instance == null)
            {
                instance = new HttpRequestHelper();
            }
            return instance;
        }


        public async Task<T> GetAsync<T>(string baseUrl, string endpoint, Dictionary<string, string> headers, Dictionary<string, string> parameters)
        {
            using var client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            //client.DefaultRequestHeaders.Add("host", "www.foody.vn");
            //client.DefaultRequestHeaders.Accept.Add(
            //        new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.125 Safari/537.36");
            //client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

            foreach (var e in headers)
            {
                client.DefaultRequestHeaders.Add(e.Key, e.Value);
            }
            var url = endpoint + "?" + FormatUrlParameters(parameters);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            T result = JsonConvert.DeserializeObject<T>(resp);
            return result;
        }

        private string FormatUrlParameters(Dictionary<string, string> parameters)
        {
            return string.Join("&", parameters.Select(x => x.Key + "=" + x.Value).ToArray());
        }
    }
}

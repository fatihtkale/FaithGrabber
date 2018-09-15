using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FaithGrapper
{
    public class FaithClient
    {
        HttpClient client;
        public Data data;
        
        public async Task<Data> Data(string ip)
        {
            client = new HttpClient();
            var getip = WebUtility.UrlEncode(ip);
            string json = await client.GetStringAsync($"https://ipapi.co/{ip}/json");
            Data data = JsonConvert.DeserializeObject<Data> (json);

            return data;
        }
    }
}
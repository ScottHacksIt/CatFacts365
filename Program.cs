using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CatFacts365
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // send the request
            string uri = "https://cat-fact.herokuapp.com/facts/random";
            HttpRequestMessage req = new HttpRequestMessage();
            req.RequestUri = new Uri(uri);
            req.Method = HttpMethod.Get;
            req.Headers.Clear();
            req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpClient _client = new HttpClient();            
            HttpResponseMessage resp = await _client.SendAsync(req);
            // make sure it was successful
            resp.EnsureSuccessStatusCode();
            // extract the json contents from the response
            string jsonContent = "";
            if (resp.Content != null)
                jsonContent = await resp.Content.ReadAsStringAsync();
            // parse them
            JToken jsonObj = JsonConvert.DeserializeObject<object>(jsonContent) as JToken;
            // get that sweet cat fact
            string catFact = jsonObj["text"].ToString();
            Console.WriteLine(catFact);
        }
    }
}

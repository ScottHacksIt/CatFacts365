using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using AnimalFactsLib;

namespace CatFacts365
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //AnimalFact factRetriever = new CatFact();
            AnimalFact factRetriever = new DogFact();
            string fact = await factRetriever.GetFact();
            Console.WriteLine(fact);
        }
    }
}

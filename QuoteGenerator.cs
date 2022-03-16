using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyesURL = "https://api.kanye.rest";
            var kanyesResponse = client.GetStringAsync(kanyesURL).Result;
            var kanyesQuote = JObject.Parse(kanyesResponse).GetValue("quote").ToString();

            Console.WriteLine($"\nKanye says:\n   { kanyesQuote}");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronsURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronsResponse = client.GetStringAsync(ronsURL).Result;
            var ronsQuote = JArray.Parse(ronsResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();

            Console.WriteLine($"\nRon responds:\n   {ronsQuote}");
        }

    }
}

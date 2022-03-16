using System;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace KanyeAndRon

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get some wisdom from Ron Swanson and Kanye West. \n\n\n");

            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();

            Console.WriteLine("\n\n**Still enjoying it? Press 1 to continue or 0 to stop the fun.");

            bool cont = true;
            var userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                cont = true;
            }
            else
            {
                cont = false;
                Environment.Exit(0);
            }

            do
            {
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();

                Console.WriteLine("\n\n**Still enjoying it? Press 1 to continue or 0 to stop the fun.");
                userResponse = Console.ReadLine();
                Console.ReadKey();

            }
            while (cont == true);
        }
    }
}
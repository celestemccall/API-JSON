using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RonSwansonAndKanyeWest
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.WriteLine("Kanye: I am going to tell one of my famous quotes, then you should tell one of yours!");
            Console.WriteLine("Ron: Sounds good to me, lets do it!");

            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.kanyeQuote();

                QuoteGenerator.ronQuote();
            }

        }
    }
}
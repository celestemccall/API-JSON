﻿using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RonSwansonAndKanyeWest
{
    public class QuoteGenerator
    {

    public static void kanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            Console.WriteLine("-----------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine("-----------------");

        }

        
        public static void ronQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("-----------------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine("-----------------");

           
        }


    }

     
}


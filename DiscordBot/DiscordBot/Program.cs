using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;
using System.Runtime.InteropServices;

namespace DiscordBot
{
    internal class Program
    {
        public static string outputFile = @"C:\Users\linde\github\appTBA\DiscordBot\DiscordBot\fileoutut.txt";

        static void Main(string[] args)
        {
            //var bot = new Bot();
            //bot.RunAsync().GetAwaiter().GetResult();
            //var smhi = new SMHI();
            //smhi.RunAsync().GetAwaiter().GetResult();

            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result; //type string
            }
        }
    }
}

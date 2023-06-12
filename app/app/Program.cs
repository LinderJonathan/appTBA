using System;
using System.IO;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace app
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //TODO: set up new keys
            string APIKey = "4ZoXt2IYve4wXxXvJpx8T62lR";
            string APISecret = "x2Hg03EKOKK1ndNBP5kuX7WSrhHjFDv5fJfF6boRn0mGcQ3h7t";
            string accessToken = "746834551578759169-S2EO5hD7yrK5l0XzEaUF30bxAh0N360";
            string accessTokenSecret = "bmj5Kw7r0b8Zj3TAo0qaaAv71HHDpsYwmS2WG7t6BAZUI";
            Console.Write("Main method" + "\n");
            TwitterClient UserClient = new TwitterClient(APIKey, APISecret, accessToken, accessTokenSecret);
            var user = await UserClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine(user);
            Console.Write("Main method" + "\n");

            //TODO: fix write to twitter
            // Still have no access to standard API v1.1
            var tweet = await UserClient.Tweets.PublishTweetAsync("Hahaha kolla på min soon to be bot");
            Console.WriteLine(tweet);

        }
    }
}

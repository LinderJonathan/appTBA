using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiscordBot
{
    public class SMHI
    {
        static HttpClient httpClient = new HttpClient();

        //TODO: get coordinates for given city from json object
        public (double, double) GetCityCoordinates(string city)
        {
            string json = "";
            using (StreamReader sr = new StreamReader("cityDataSE.json"))
                json = sr.ReadToEnd();
                //TODO: extract the data 

                return (0.0, 0.0);
        }
        //TODO: 
        static async Task<Uri> GetForecast(string path)
        {
            //path = base string together with inputs from the discord command
            path = "api/category/{category}/version/{version}/geotype/point/lon/{longitude}/lat/{latitude}";
            HttpResponseMessage response = await httpClient.GetAsync(path);
            return response.Headers.Location;
        }
    }
}

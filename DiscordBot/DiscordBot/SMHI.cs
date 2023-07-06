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

    /*
     * TODO:
     * get the uri that is needed to GET data for forecasts
     */
    public class SMHI
    {
        public string version = "1.0";
        public string entryObs { get; set; } = "http://opendata-download-metobs.smhi.se/api"; //entry for observations
        public string entryAnl { get; set; } = "http://opendata-download-metanalys.smhi.se/api"; //entry for analysis
        public async Task RunAsync()
        {
            await GetForecast("api / category / pmp3g / version / 2 / geotype / point / lon / 16 / lat / 58");
        }
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
            var uri = new Uri($"{entryObs}"); //Fix
            //path = base string together with inputs from the discord command: api/category/{category}/version/{version}/geotype/point/lon/{longitude}/lat/{latitude} example
            path = "api/category/pmp3g/version/2/geotype/point/lon/16/lat/58";
            HttpResponseMessage response = await httpClient.GetAsync(path);
            Console.WriteLine(response.Content);
            return response.Headers.Location;
        }
    }
}

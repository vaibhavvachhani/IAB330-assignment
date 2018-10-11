using fishy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace fishy.Services
{
    public class WeatherService
    {
        private const string OpenWeatherMapAPIKey = "9fee9fc1725d40196ba495d7ad3db0c1";
        static HttpClient client;

        public static async Task<WeatherInfo> GetWeatherInfo(double latitude, double longitude)
        {
            try
            {
                client = new HttpClient
                {
                    MaxResponseContentBufferSize = 256000
                };
                var apiUrl = String.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid={2}", latitude, longitude, OpenWeatherMapAPIKey);

                var uri = new Uri(apiUrl);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<WeatherInfo>(result);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetWeatherInfo exception: " + ex.Message);
            }
            return null;
        }

    }
}

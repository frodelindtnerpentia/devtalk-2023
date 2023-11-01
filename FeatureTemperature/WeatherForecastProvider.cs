using FeatureTemperature.Models.Transport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature
{
    public class WeatherForecastProvider : IWeatherForecastProvider
    {
        public WeatherForecastProvider() { }

        public async Task<List<WeatherForecastItem>> GetWeatherForecastsAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7031/WeatherForecast");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<List<WeatherForecastItem>>(data);

            return result;
        }
    }
}

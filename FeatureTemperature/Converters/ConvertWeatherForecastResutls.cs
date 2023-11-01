using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature.Converters
{
    public static class ConvertWeatherForecast
    {
        public static Models.TemperatureItem GetResults(Models.Transport.WeatherForecastItem input)
        {
            Models.TemperatureItem temperatureItem = new()
            {
                Date = input.date,
                Temperature = Helpers.GetTemperature.GetCorrectTemperature(input),
                Place = input.city
            };

            return temperatureItem;
        }
    }
}

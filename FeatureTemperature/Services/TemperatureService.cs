using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature.Services
{
    public class TemperatureService : ITempertatureService
    {
        private readonly IWeatherForecastProvider _weatherForecastProvider;

        public TemperatureService() 
        { 
            _weatherForecastProvider = new WeatherForecastProvider();
        }

        public Models.TemperatureItem GetTemperatureByPlace(string place) 
        {            
            var resultFromExternal = _weatherForecastProvider.GetWeatherForecastsAsync().Result;
            var item = resultFromExternal.FirstOrDefault(x => x.city == place);

            Models.TemperatureItem returnTemperature = new();

            if (item != null)
            {
                returnTemperature.Date = item.date;
                returnTemperature.Place = item.city;
                returnTemperature.Temperature = item.temperatureC;
            }

            return returnTemperature;
        }

    }
}

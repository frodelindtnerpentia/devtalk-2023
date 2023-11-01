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
            var list = resultFromExternal.Forecasts;
            var item = list.FirstOrDefault(x => x.city == place);

            Models.TemperatureItem returnTemperature = new()
            {
                Date = item.date,
                Place = item.city,
                Temperature = item.temperatureC
            };
            return returnTemperature;
        }

    }
}

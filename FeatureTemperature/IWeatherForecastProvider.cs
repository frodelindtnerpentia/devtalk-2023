using FeatureTemperature.Models.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature
{
    public interface IWeatherForecastProvider
    {
        public Task<List<WeatherForecastItem>> GetWeatherForecastsAsync();
    }
}

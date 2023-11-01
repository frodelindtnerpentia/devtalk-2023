using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature.Models.Transport
{
    public class WeatherForecastList
    {
        public List<WeatherForecastItem> Forecasts { get; set; }
    }
    public class WeatherForecastItem
    {
        public DateTime date { get; set; }
        public int temperatureC { get; set; }
        public int temperatureF { get; set; }
        public string summary { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double geoLocation { get; set; }
        public int averageTemp { get; set; }
    }
}

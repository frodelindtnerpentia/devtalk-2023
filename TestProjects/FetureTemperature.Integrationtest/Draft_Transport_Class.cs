using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetureTemperature.Integrationtest
{
    public class Draft_Transport_Class
    {
        public List<WeatherItem> weatherItems;
    }

    public class WeatherItem
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

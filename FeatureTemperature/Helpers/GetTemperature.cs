using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature.Helpers
{
    public static class GetTemperature
    {
        public static int GetCorrectTemperature(Models.Transport.WeatherForecastItem item)
        {
            return item.temperatureF;
        }
    }
}

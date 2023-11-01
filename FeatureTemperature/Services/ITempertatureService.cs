using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureTemperature.Services
{
    public interface ITempertatureService
    {
        public Models.TemperatureItem GetTemperatureByPlace(string place);
    }
}

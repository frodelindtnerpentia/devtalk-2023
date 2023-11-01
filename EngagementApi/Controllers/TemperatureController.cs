using EngagementApi.Models;
using FeatureTemperature.Models;
using FeatureTemperature.Services;
using Microsoft.AspNetCore.Mvc;

namespace EngagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<TemperatureMockController> _logger;
        private readonly ITempertatureService _tempertatureService;

        public TemperatureController(ILogger<TemperatureMockController> logger)
        {
            _tempertatureService = new TemperatureService();
            _logger = logger;
        }

        [HttpGet(Name = "GetTemperaturByPlace")]
        public TemperatureItem GetTemperaturByPlace(string place)
        {
            var result = _tempertatureService.GetTemperatureByPlace(place);

            return result;
        }

    }
}
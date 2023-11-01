using EngagementApi.Models;
using FeatureTemperature.Services;
using Microsoft.AspNetCore.Mvc;

namespace EngagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureMockController : ControllerBase
    {
        private readonly ILogger<TemperatureMockController> _logger;
        private ITempertatureService _tempertatureService;

        public TemperatureMockController(ILogger<TemperatureMockController> logger)
        {
            _tempertatureService = new TemperatureService();
            _logger = logger;
        }

        [HttpGet(Name = "GetTemperaturMockup")]
        public TemperatureMockItem GetTemperaturMockup()
        {
            return new TemperatureMockItem
            {
                Date = DateTime.Now,
                Place = "et sted",
                Temperature = 12
            };
        }

    }
}
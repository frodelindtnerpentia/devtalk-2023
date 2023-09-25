using EngagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EngagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<TemperatureController> _logger;

        public TemperatureController(ILogger<TemperatureController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTemperature")]
        public TemperatureItem GetTemperaturMockup()
        {
            return new TemperatureItem
            {
                Date = DateTime.Now,
                Place = "et sted",
                Temperature = 12
            };
        }
    }
}
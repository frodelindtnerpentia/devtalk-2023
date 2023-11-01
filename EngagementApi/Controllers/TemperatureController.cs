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
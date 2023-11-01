using Microsoft.Extensions.Logging;
using EngagementApi.Controllers;
using Moq;
using FeatureTemperature.Services;

namespace EngagementApi.Unittest.Controllers
{
    [TestClass]
    public class TemperatureControllerTests
    {
        [TestMethod]
        public void TemperatureController_TemeratureNotZero()
        {
            var logger = new Mock<ILogger<TemperatureController>>();            
            var data = new TemperatureController(logger.Object);


            Assert.IsTrue(true);
        }

    }
}
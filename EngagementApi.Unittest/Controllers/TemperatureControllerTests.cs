using Microsoft.Extensions.Logging;
using EngagementApi.Controllers;
using Moq;

namespace EngagementApi.Unittest.Controllers
{
    [TestClass]
    public class TemperatureControllerTests
    {
        [TestMethod]
        public void TemperatureControllerTest_TemeratureNotZero()
        {
            var logger = new Mock<ILogger<TemperatureController>>();
            var data = new TemperatureController(logger.Object).GetTemperaturMockup();

            Assert.IsTrue(data.Temperature != 0);
        }

    }
}
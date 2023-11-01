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
            var logger = new Mock<ILogger<TemperatureMockController>>();
            var data = new TemperatureMockController(logger.Object).GetTemperaturMockup();

            Assert.IsTrue(data.Temperature != 0);
        }

    }
}
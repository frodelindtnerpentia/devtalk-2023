using Newtonsoft.Json;
using RestSharp;

namespace FetureTemperature.Integrationtest
{
    [TestClass]
    public class WeatherForecastUnitTest1
    {
        [TestMethod]
        public async Task WeatherForecastTestMethod1Async()
        {
            var options = new RestClientOptions("https://localhost:7031")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/WeatherForecast", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        [TestMethod]
        public async Task WeatherForecastTestMethod1Async_aslist()
        {
            var options = new RestClientOptions("https://localhost:7031")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/WeatherForecast", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);

            var result = JsonConvert.DeserializeObject<List<WeatherItem>>(response.Content.ToString());
            Assert.IsTrue(result.Count() != 0);
        }
    }
}
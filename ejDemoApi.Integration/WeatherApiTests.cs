using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;

namespace ejDemoApi.Integration
{
    public class WeatherApiTests
    {

        private readonly HttpClient _apiClient;

        public WeatherApiTests()
        {
            var appFactory = new WebApplicationFactory<Program>();
            _apiClient = appFactory.CreateClient();
        }

        [Fact]
        public void ShoudlReturnSuccesfullResponse()
        {
            var result = _apiClient.GetAsync("/weatherforecast").Result;

            Assert.NotNull(result);
            Assert.Equal(System.Net.HttpStatusCode.OK,  result.StatusCode);

        }
    }
}
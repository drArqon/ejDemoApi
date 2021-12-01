using Xunit;

namespace ejDemoApi.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void ServiceReturnsForeacastWhenCalled()
        {
            var weatherService = new WeatherService();

            Assert.NotNull(weatherService.GetForecast()); 
            Assert.NotEmpty(weatherService.GetForecast());

        }
    }
}
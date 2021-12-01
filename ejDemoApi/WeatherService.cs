namespace ejDemoApi
{
    public class WeatherService
    {
        private static string[] summaries = new[] { "Hot", "Sweltering", "Scorching" };
        public WeatherForecast[] GetForecast()
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
               new WeatherForecast
               (
                   DateTime.Now.AddDays(index),
                   Random.Shared.Next(-20, 55),
                   summaries[Random.Shared.Next(summaries.Length)]
               )).ToArray();

            return forecast;
        }
    }


    public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestThing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] ColdSummaries = new[]
        {
            "Freezing", "Bracing", "Chilly"
        };

        private static readonly string[] MidSummaries = new[]
{
            "Cool", "Mild", "Warm", "Balmy"
        };

        private static readonly string[] HotSummaries = new[]
{
             "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            
            for (int i = 0; i<=5; i++){
                var tempTemp = rng.Next(-20, 55);
                var tempHum = rng.Next(0, 100);
                var forecast = new WeatherForecast 
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = tempTemp,
                    Humidity = tempHum,


                    TempSummary = DetermineTempSummary(tempTemp),
                    HumSummary = DetermineHumSummary(tempHum)

                };
                yield return forecast;
            }
            

        }
        
        private string DetermineTempSummary(int temp)
        {
            var rng = new Random();
            var sumResult = string.Empty; 
            
            if (temp >= 40){
                sumResult = HotSummaries[rng.Next(HotSummaries.Length)];
            }
            else if (temp <= 39 && temp >= 10)
            {
                sumResult = MidSummaries[rng.Next(MidSummaries.Length)];
            }
            else sumResult = ColdSummaries[rng.Next(ColdSummaries.Length)];

            return sumResult;
        }

        private string DetermineHumSummary(int hum)
        {

        var rng = new Random();
            var sumResult = string.Empty;

            if (hum >= 70)
            {
                sumResult = "Tropical";
            }
            else if (hum <= 69 && hum >= 30)
            {
                sumResult = "Fairly Humid";
            }
            else sumResult = "Dry";

            return sumResult;
        }

    }
}

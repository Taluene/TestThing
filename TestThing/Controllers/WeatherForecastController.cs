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
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),

                Summary = ColdSummaries[rng.Next(ColdSummaries.Length)]
            }

                //THIS IS WHERE IM STUCK

            )
            .ToArray();
        }
    }
}

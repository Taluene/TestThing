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
                var tempTemp = rng.Next(-20, 55),
                var forecast = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = tempTemp
                    
                     
                    
                    Summary = DetermineSummary(tempTemp)
                }               
                yield return forecast
            }
            

        }
        
        private string DetermineSummary(int temp)
        {
            if temp hjasdjhasdfjhasdfjhkasdf
        
        }
        
    }
}

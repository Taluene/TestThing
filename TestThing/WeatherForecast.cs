using System;

namespace TestThing
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int Humidity { get; set; }

        public string TempSummary { get; set; }

        public string HumSummary { get; set; }

    }
}

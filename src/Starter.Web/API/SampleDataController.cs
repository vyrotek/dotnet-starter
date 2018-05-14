using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Starter.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Starter.Web.API
{
    [Route("api/SampleData")]
    public class SampleDataController : Controller
    {
        private StarterDB _db;

        public SampleDataController(Settings settings, StarterDB db)
        {
            _db = db;
        }

        [HttpGet("Data")]
        public async Task<object> Data()
        {
            return new { Hello = "Hi" };
        }

        [HttpGet("WeatherForecasts")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = "Test"
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}

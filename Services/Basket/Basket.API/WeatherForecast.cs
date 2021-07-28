using System;

namespace Basket.API
{
    public class WeatherForecast
    {
        //docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}

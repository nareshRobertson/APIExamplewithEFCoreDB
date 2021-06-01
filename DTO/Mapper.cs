using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIExamplewithEFCoreDB.DTO
{
    public class Mapper
    {
        public WeatherForecastDTO Map(WeatherForecast forecast)
        {
            return new WeatherForecastDTO
            {
                Id = forecast.Id,
                Date = forecast.Date,
                Summary = forecast.Summary,
                TemperatureC = forecast.TemperatureC,
                TemperatureF = forecast.TemperatureF
            };
        }

        public WeatherForecast Map(WeatherForecastDTO forecastDTO)
        {
            return new WeatherForecast
            {
                Id = forecastDTO.Id,
                Date = forecastDTO.Date,
                Summary = forecastDTO.Summary,
                TemperatureC = forecastDTO.TemperatureC
            };
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Core.Entities.Models
{
    public class WeatherModel
    {
        public string WeatherText { get; set; }
        public string WeatherIcon { get; set; }
        public double FeelsLike { get; set; }
        public string UpdatedAt { get; set; }
    }
}

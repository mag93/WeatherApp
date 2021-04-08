using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class WeatherType
    {
        public string CityName { get; set; }
        public double Temperature { get; set; }
        public string WeatherClimate { get; set; }
        public string Climate { get; set; }
        public string ErrorMessage { get; set; }
        public string PhotoURL { get; set; }

        public WeatherType()
        {

        }

    }
}

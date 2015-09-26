using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSampleWeather
{
    public class Weather
    {
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public float Humidity { get; set; }
        public float Temperature { get; set; }
        public string City { get; set; }

        public string CityImage { get; set; }
    }
}

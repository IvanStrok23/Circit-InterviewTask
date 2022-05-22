using CityInfo.Core.Entities.Entities;


namespace CityInfo.Core.Entities.DTO
{
    public class WeatherDTO
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
    }

}

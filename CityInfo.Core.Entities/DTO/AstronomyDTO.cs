

using CityInfo.Core.Entities.Entities;

namespace CityInfo.Core.Entities.DTO
{
    public class AstronomyDTO
    {
        public Location Location { get; set; }
        public Astronomy Astronomy { get; set; }
    }

    public class Astronomy
    {
        public Astro Astro { get; set; }
    }

}

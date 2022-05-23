using Newtonsoft.Json;

namespace CityInfo.Core.Entities.Entities
{
    public class Astro
    {
        [JsonProperty("sunrise")]
        public string SunRise { get; set; }

        [JsonProperty("sunset")]
        public string SunSet { get; set; }

        [JsonProperty("moonrise")]
        public string MoonRise { get; set; }

        [JsonProperty("moonset")]
        public string MoonSet { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonProperty("moon_illumination")]
        public string MoonIllumination { get; set; }
    }
}

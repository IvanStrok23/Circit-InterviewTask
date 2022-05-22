using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityInfo.Core.Entities.Entities
{
    public class Current
    {
        [JsonProperty("last_updated_epoch")]
        public int LastUpdateEpoch { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty("temp_c")]
        public double TemperatureCelsius { get; set; }

        [JsonProperty("temp_f")]
        public double TemperatureFahrenheit { get; set; }

        [JsonProperty("is_day")]
        public double IsDay { get; set; }

        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDirection { get; set; }

        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelslikeCelsius { get; set; }

        [JsonProperty("feelslike_f")]
        public double FeelslikeFahrenheit { get; set; }

        [JsonProperty("vis_km")]
        public double VisKm { get; set; }

        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("gust_mph")]
        public double GustMph { get; set; }

        [JsonProperty("gust_kph")]
        public double GustKph { get; set; }

    }

    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}

using CityInfo.BLL.Interfaces.API;
using CityInfo.BLL.Interfaces.CityInfo;
using CityInfo.BLL.Services.Base;
using CityInfo.Core.Entities.DTO;
using CityInfo.Core.Entities.Helpers;
using CityInfo.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.BLL.Services.CityInfo
{

    public class WeatherApiService : ApiServiceBase, IWeatherApiService
    {
        private readonly IApiRequest _apiRequest;

        public WeatherApiService(ApiConfig config, IApiRequest apiRequest) :
            base(config)
        {
            _apiRequest = apiRequest;
        }


        public async Task<WeatherModel> GetWeather(string city)
        {
            WeatherDTO weatherFull = await _apiRequest.Get<WeatherDTO>(BuildRequest(HttpMethod.Get, string.Format("current.json?q={0}", city)));
            if (weatherFull == null || weatherFull.Current == null || weatherFull.Current.Condition == null) { return null; }
            return new WeatherModel()
            {
                WeatherText = weatherFull.Current.Condition.Text,
                WeatherIcon = weatherFull.Current.Condition.Icon,
                FeelsLike = weatherFull.Current.FeelslikeCelsius,
                UpdatedAt = weatherFull.Current.LastUpdate.ToString("dddd, dd MMMM yyyy HH:mm:ss"),
            };
        }
    }
}

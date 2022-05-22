using CityInfo.BLL.Interfaces.CityInfo;
using CityInfo.BLL.Services.CityInfo;
using CityInfo.Core.Entities.DTO;
using CityInfo.Core.Entities.Helpers;
using CityInfo.Core.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.PL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWeatherApiService _weatherApiService;
        private readonly IAstronomyApiService _astronomyApiService;
        private readonly ITimezoneApiService _timeZoneApiService;
        public HomeController(IWeatherApiService weatherApiService, IAstronomyApiService astronomyApiService, ITimezoneApiService timeZoneApiService)
        {
            _weatherApiService = weatherApiService;
            _astronomyApiService = astronomyApiService;
            _timeZoneApiService = timeZoneApiService;
        }


        [HttpGet("getWeather")]
        public async Task<WeatherModel> GetWeather(string cityName)
        {
            return await _weatherApiService.GetWeather(cityName);
        }

        [HttpGet("getAstronomy")]
        public async Task<AstronomyModel> GetAstronomy(string cityName)
        {
            return await _astronomyApiService.GetAstronomy(cityName);
        }

        [HttpGet("getTimeZone")]
        public async Task<TimeZoneModel> GetTimeZone(string cityName)
        {
            return await _timeZoneApiService.GetTimeZone(cityName);
        }
    }
}

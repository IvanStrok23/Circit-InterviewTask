using CityInfo.Core.Entities.DTO;
using CityInfo.Core.Entities.Models;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.CityInfo
{
    public interface IWeatherApiService
    {
        public Task<WeatherModel> GetWeather(string city);
    }
}

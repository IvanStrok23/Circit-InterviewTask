using CityInfo.Core.Entities.Models;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.CityInfo
{
    public interface ITimezoneApiService
    {
        public Task<TimeZoneModel> GetTimeZone(string city);

    }
}

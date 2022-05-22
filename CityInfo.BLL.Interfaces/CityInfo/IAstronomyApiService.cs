

using CityInfo.Core.Entities.Models;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.CityInfo
{
    public interface IAstronomyApiService
    {
        public Task<AstronomyModel> GetAstronomy(string city);
    }
}

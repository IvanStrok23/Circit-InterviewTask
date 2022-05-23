using System.Net.Http;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.API
{
    public interface IApiRequest
    {
        public Task<T> Get<T>(HttpRequestMessage httpRequestMessage);
    }
}

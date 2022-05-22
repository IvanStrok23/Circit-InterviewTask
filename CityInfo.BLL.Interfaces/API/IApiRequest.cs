using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.API
{
    public interface IApiRequest
    {
        public Task<T> Get<T>(HttpRequestMessage httpRequestMessage);
    }
}

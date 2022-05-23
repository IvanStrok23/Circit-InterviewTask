using CityInfo.Core.Entities.Helpers;
using System;
using System.Net.Http;

namespace CityInfo.BLL.Services.Base
{
    public abstract class ApiServiceBase
    {
        protected readonly string _apiUrlBase;
        protected readonly string _apiHost;
        protected readonly string _apiKey;

        public ApiServiceBase(ApiConfig config)
        {
            _apiUrlBase = config.UrlBase;
            _apiHost = config.Host;
            _apiKey = config.Key;
        }

        protected HttpRequestMessage BuildRequest(HttpMethod method, string tableTarget)
        {
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(string.Format("{0}{1}", _apiUrlBase, tableTarget)),
                Headers =
                {
                    { "x-rapidapi-host", _apiHost },
                    { "x-rapidapi-key", _apiKey },
                },
            };
        }
    }
}

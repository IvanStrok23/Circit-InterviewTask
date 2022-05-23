using CityInfo.BLL.Interfaces.API;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityInfo.BLL.Services.API
{
    public class ApiRequest : IApiRequest
    {
        private readonly HttpClient _httpClient;

        public ApiRequest(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<T> Get<T>(HttpRequestMessage httpRequestMessage)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string contentString = await httpResponseMessage.Content.ReadAsStringAsync();
                var contentObject = JsonConvert.DeserializeObject<T>(contentString);
                return contentObject;
            }
            else
            {
                if (httpResponseMessage.Content != null)
                {
                    httpResponseMessage.Content.Dispose();
                }
                return await Task.FromResult<T>(default(T));
            }
        }
    }
}

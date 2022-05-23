namespace CityInfo.Core.Entities.Helpers
{
    public class ApiConfig
    {
        public string UrlBase {get;set;}
        public string Host { get; set; }
        public string Key { get; set; }

        public ApiConfig(string urlBase, string host, string key)
        {
            UrlBase = urlBase;
            Host = host;
            Key = key;
        }
    }
}

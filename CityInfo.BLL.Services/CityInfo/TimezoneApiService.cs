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
    public class TimezoneApiService : ApiServiceBase, ITimezoneApiService
    {

        private readonly IApiRequest _apiRequest;
        public TimezoneApiService(ApiConfig config, IApiRequest apiRequest) :
            base(config)
        {
            _apiRequest = apiRequest;
        }

        public async Task<TimeZoneModel> GetTimeZone(string city)
        {
            //TODO: Use mapper
            TimeZoneDTO timeZoneFull = await _apiRequest.Get<TimeZoneDTO>(BuildRequest(HttpMethod.Get, string.Format("timezone.json?q={0}", city)));
            if( timeZoneFull == null || timeZoneFull.Location == null) { return null; }
            return new TimeZoneModel() { Name = timeZoneFull.Location.Name, Country = timeZoneFull.Location.Country, Region = timeZoneFull.Location.Region };
        }
    }
}

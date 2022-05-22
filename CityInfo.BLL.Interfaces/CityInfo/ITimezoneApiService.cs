using CityInfo.Core.Entities.DTO;
using CityInfo.Core.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.BLL.Interfaces.CityInfo
{
    public interface ITimezoneApiService
    {
        public Task<TimeZoneModel> GetTimeZone(string city);

    }
}

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
    public class AstronomyApiService : ApiServiceBase, IAstronomyApiService
    {
        private readonly IApiRequest _apiRequest;
        public AstronomyApiService(ApiConfig config, IApiRequest apiRequest) :
            base(config)
        {
            _apiRequest = apiRequest;
        }

        public async Task<AstronomyModel> GetAstronomy(string city)
        {
            AstronomyDTO astronomyFull = await _apiRequest.Get<AstronomyDTO>(BuildRequest(HttpMethod.Get, string.Format("astronomy.json?q={0}", city)));
            if (astronomyFull == null || astronomyFull.Astronomy == null || astronomyFull.Astronomy.Astro == null) { return null; }
            return new AstronomyModel()
            {
                MoonPhase = astronomyFull.Astronomy.Astro.MoonPhase,
                MoonRise = astronomyFull.Astronomy.Astro.MoonRise,
                MoonSet = astronomyFull.Astronomy.Astro.MoonSet,
                SunRise = astronomyFull.Astronomy.Astro.SunRise,
                SunSet = astronomyFull.Astronomy.Astro.SunSet
            };
        }
    }
}

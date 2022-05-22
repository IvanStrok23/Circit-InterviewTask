using CityInfo.BLL.Interfaces.API;
using CityInfo.BLL.Interfaces.CityInfo;
using CityInfo.BLL.Services.API;
using CityInfo.BLL.Services.CityInfo;
using CityInfo.Core.Entities.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.PL.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpClient();
            services.AddScoped<IApiRequest, ApiRequest>();

            var apiProviderData = Configuration.GetSection("API").GetSection("WeatherProviders").GetSection("Rapidapi");

            ApiConfig rapidapiConfig = new ApiConfig(
                apiProviderData.GetSection("ApiUrl").Value, 
                apiProviderData.GetSection("ApiHost").Value, 
                apiProviderData.GetSection("ApiKey").Value);

            services.AddScoped<IWeatherApiService>(ws => new WeatherApiService(rapidapiConfig, ws.GetRequiredService<IApiRequest>()));
            services.AddScoped<IAstronomyApiService>(ws => new AstronomyApiService(rapidapiConfig, ws.GetRequiredService<IApiRequest>()));
            services.AddScoped<ITimezoneApiService>(ws => new TimezoneApiService(rapidapiConfig, ws.GetRequiredService<IApiRequest>()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

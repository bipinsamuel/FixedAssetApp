using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApp.API.Extensions
{
    public static class ServiceExtension
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAssetService, AssetService>();            
        }
    }
}

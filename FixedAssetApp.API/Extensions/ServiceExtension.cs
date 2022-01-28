using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Business.Services;
using FixedAssetApp.Data.Interfaces;
using FixedAssetApp.Data.Repository;
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
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IMaintenanceService, MaintenanceService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IVendorService, VendorService>();
            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IMaintenanceRepository, MaintenanceRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IVendorRepository, VendorRepository>();
        }
    }
}

using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Business.Services
{
    public class DashboardService : IDashboardService
    {
        private IDashboardRepository _dashboardRepository;
        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }
    }
}

using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Data.Interfaces;
using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Business.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private IMaintenanceRepository _maintenanceRepository;
        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public Task Add(Maintenance maintenance)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Maintenance> GetAllMaintenances()
        {
            throw new NotImplementedException();
        }

        public Asset GetMaintenance(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Maintenance maintenance)
        {
            throw new NotImplementedException();
        }
    }
}

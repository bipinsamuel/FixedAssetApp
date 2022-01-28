using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Business.Interfaces
{
    public interface IMaintenanceService
    {
        Task Add(Maintenance maintenance);
        Task Update(Maintenance maintenance);
        Task Delete(int id);
        Asset GetMaintenance(int id);
        IEnumerable<Maintenance> GetAllMaintenances();
    }
}

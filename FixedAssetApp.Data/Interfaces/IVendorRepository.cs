using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Data.Interfaces
{
    public interface IVendorRepository
    {
        bool Add(Vendor vendor);
        bool Update(Vendor vendor);
        bool Delete(int id);
        Vendor GetVendor(int id);
        IEnumerable<Vendor> GetAllVendors();
    }
}

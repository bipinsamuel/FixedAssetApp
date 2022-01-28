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
    /// <summary>
    /// Vendor Service
    /// </summary>
    public class VendorService : IVendorService
    {
        private IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        /// <summary>
        /// Add vendor
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public bool Add(Vendor vendor)
        {
            return _vendorRepository.Add(vendor);
        }

        /// <summary>
        /// Delete vendor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// get all vendors
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> GetAllVendors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// get a single vendor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vendor GetVendor(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// update vendor
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public bool Update(Vendor vendor)
        {
            throw new NotImplementedException();
        }
    }
}

using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixedAssetApp.API.Controllers
{
    /// <summary>
    /// Vendor Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private IVendorService _vendorService;
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        /// <summary>
        /// Add a vendor
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Vendor vendor)
        {
            var success = _vendorService.Add(vendor);
            return Ok(success);
        }
    }
}

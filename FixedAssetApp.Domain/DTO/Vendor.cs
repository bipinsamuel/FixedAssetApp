using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Domain.DTO
{
    public class Vendor
    {
        public string VendorNo { get; set; }
        public DateTime VendorOnboardDate { get; set; }
        public string CompanyName { get; set; }
        public Guid CompanyType { get; set; }
        public string CompanySalesAddress { get; set; }
        public string Pincode { get; set; }
        public string GstNo { get; set; }
        public string PanNo { get; set; }
        public Guid District { get; set; }
        public Guid Vendorstate { get; set; }
        public Guid Country { get; set; }
        public string SalesPocName { get; set; }
        public string SalesPocDesignation { get; set; }
        public string SalesPocMobile { get; set; }
        public string SalesPocEmail { get; set; }
        public string CompanyServiceAddress { get; set; }
        public string ServicePocName { get; set; }
        public string ServicePocDesignation { get; set; }
        public string ServicePocMobile { get; set; }
        public string ServicePocEmail { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime VerifiedOn { get; set; }
    }
}

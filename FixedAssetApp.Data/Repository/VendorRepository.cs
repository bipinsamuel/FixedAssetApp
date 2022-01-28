using FixedAssetApp.Data.Helper;
using FixedAssetApp.Data.Interfaces;
using FixedAssetApp.Data.Queries;
using FixedAssetApp.Domain.DTO;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Data.Repository
{
    /// <summary>
    /// Vendor Repository
    /// </summary>
    public class VendorRepository : IVendorRepository
    {
        private AdoHelper _adoHelper;
        public VendorRepository(IConfiguration configuration)
        {
            AdoHelper.ConnectionString = configuration.GetSection("Database:FixedAssetConStr").Value;
            _adoHelper = new AdoHelper();
        }

        /// <summary>
        /// Add vendor
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public bool Add(Vendor vendor)
        {
            bool success = false;
            //try
            //{
            //    string cmdText = $"call public.sp_insert_vendor(:vendorNo,:vendorOnboardDate,:companyName,:companyType,:companySalesAddress,:pincode,:gstNo,:panNo,:district,:vendorstate,:country,:salesPocName,:salesPocDesignation,:salesPocMobile,:salesPocEmail,:companyServiceAddress,:servicePocName,:servicePocDesignation,:servicePocMobile,:servicePocEmail,:createdBy,:createdOn,:modifiedBy,:modifiedOn,:verifiedBy,:verifiedOn)";
            //    using (var connection = _adoHelper.Connection())
            //    {
            //        connection.Open();
            //        using (var cmd = new NpgsqlCommand(cmdText, connection))
            //        {
            //            cmd.Parameters.AddWithValue("vendorNo", DbType.String).Value = vendor.VendorNo;
            //            cmd.Parameters.AddWithValue("vendorOnboardDate", DbType.DateTime).Value = vendor.VendorOnboardDate;
            //            cmd.Parameters.AddWithValue("companyName", DbType.String).Value = vendor.CompanyName;
            //            cmd.Parameters.AddWithValue("companyType", DbType.String).Value = vendor.CompanyType;
            //            cmd.Parameters.AddWithValue("companySalesAddress", DbType.String).Value = vendor.CompanySalesAddress;
            //            cmd.Parameters.AddWithValue("pincode", DbType.String).Value = vendor.Pincode;
            //            cmd.Parameters.AddWithValue("gstNo", DbType.String).Value = vendor.GstNo;
            //            cmd.Parameters.AddWithValue("panNo", DbType.String).Value = vendor.PanNo;
            //            cmd.Parameters.AddWithValue("district", DbType.Guid).Value = vendor.District;
            //            cmd.Parameters.AddWithValue("vendorstate", DbType.Guid).Value = vendor.Vendorstate;
            //            cmd.Parameters.AddWithValue("country", DbType.Guid).Value = vendor.Country;
            //            cmd.Parameters.AddWithValue("salesPocName", DbType.String).Value = vendor.SalesPocName;
            //            cmd.Parameters.AddWithValue("salesPocDesignation", DbType.String).Value = vendor.SalesPocDesignation;
            //            cmd.Parameters.AddWithValue("salesPocMobile", DbType.String).Value = vendor.SalesPocMobile;
            //            cmd.Parameters.AddWithValue("salesPocEmail", DbType.String).Value = vendor.SalesPocEmail;
            //            cmd.Parameters.AddWithValue("companyServiceAddress", DbType.String).Value = vendor.CompanyServiceAddress;
            //            cmd.Parameters.AddWithValue("servicePocName", DbType.String).Value = vendor.ServicePocName;
            //            cmd.Parameters.AddWithValue("servicePocDesignation", DbType.String).Value = vendor.ServicePocDesignation;
            //            cmd.Parameters.AddWithValue("servicePocMobile", DbType.String).Value = vendor.ServicePocMobile;
            //            cmd.Parameters.AddWithValue("servicePocEmail", DbType.String).Value = vendor.ServicePocEmail;
            //            cmd.Parameters.AddWithValue("createdBy", DbType.String).Value = vendor.CreatedBy;
            //            cmd.Parameters.AddWithValue("createdOn", DbType.DateTime).Value = vendor.CreatedOn;
            //            cmd.Parameters.AddWithValue("modifiedBy", DbType.String).Value = vendor.ModifiedBy;
            //            cmd.Parameters.AddWithValue("modifiedOn", DbType.DateTime).Value = vendor.ModifiedOn;
            //            cmd.Parameters.AddWithValue("verifiedBy", DbType.String).Value = vendor.VerifiedBy;
            //            cmd.Parameters.AddWithValue("verifiedOn", DbType.DateTime).Value = vendor.VerifiedOn;

            //            cmd.Parameters.Add(new NpgsqlParameter("p_out", DbType.Int32) { Direction = ParameterDirection.Output });

            //            cmd.CommandType = CommandType.Text;
            //            int rowsAffected = cmd.ExecuteNonQuery();
            //            success = rowsAffected == 1;
            //        }                    
            //    }
            //}
            //catch(Exception exception)
            //{

            //}

            return success;
        }       

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            throw new NotImplementedException();
        }

        public Vendor GetVendor(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vendor vendor)
        {
            throw new NotImplementedException();
        }
    }
}

using FixedAssetApp.Data.Helper;
using FixedAssetApp.Data.Interfaces;
using FixedAssetApp.Domain.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Data.Repository
{
    public class AssetRepository : IAssetRepository
    {
        public AssetRepository(IConfiguration configuration)
        {
            AdoHelper.ConnectionString = configuration.GetConnectionString("Database:FixedAssetConStr");
        }
        public Task Add(Asset asset)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asset> GetAllAssets()
        {
            throw new NotImplementedException();
        }

        public Asset GetAsset(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}

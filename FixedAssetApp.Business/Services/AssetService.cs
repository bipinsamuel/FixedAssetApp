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
    public class AssetService : IAssetService
    {
        private IAssetRepository _assetRepository;
        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
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

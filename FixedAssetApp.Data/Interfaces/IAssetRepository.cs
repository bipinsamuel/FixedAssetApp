using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Data.Interfaces
{
    public interface IAssetRepository
    {
        Task Add(Asset asset);
        Task Update(Asset asset);
        Task Delete(int id);
        Asset GetAsset(int id);
        IEnumerable<Asset> GetAllAssets();
    }
}

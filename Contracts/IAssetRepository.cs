using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IAssetRepository
    {
        Task<IEnumerable<Asset>> GetAllAssetsAsync(bool trackChanges);
        Task<Asset?> GetAssetAsync(Guid assetId, bool trackChanges);
    }
}

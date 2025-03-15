using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IAssetService
    {
        Task<IEnumerable<AssetDto>> GetAllAssetsAsync(bool trackChanges);
        Task<AssetDto> GetAssetAsync(Guid assetId, bool trackChanges);
    }
}

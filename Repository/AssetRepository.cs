using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AssetRepository : RepositoryBase<Asset>, IAssetRepository
    {
        public AssetRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Asset>> GetAllAssetsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToListAsync();

        public async Task<Asset?> GetAssetAsync(Guid assetId, bool trackChanges) =>
             await FindByCondition(c => c.Id.Equals(assetId), trackChanges)
             .SingleOrDefaultAsync();
    }
}

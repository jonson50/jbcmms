using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class AssetRepository : RepositoryBase<Asset>, IAssetRepository
    {
        public AssetRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}

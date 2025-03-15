using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class AssetNotFoundException : NotFoundException
    {
        public AssetNotFoundException(Guid assetId) : base($"Asset with id: {assetId} doesn't exist in the database.")
        {
        }
    }
}

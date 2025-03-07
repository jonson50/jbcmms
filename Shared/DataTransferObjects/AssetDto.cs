using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Shared.DataTransferObjects
{
    public record AssetDto
    (
        Guid Id,
        string Name,
        string SerialNumber,
        DateTime PurchaseDate,
        Guid AssetCategoryId,
        Guid LocationId,
        Guid SupplierId
    );
    
}

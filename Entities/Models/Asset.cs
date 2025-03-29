using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; }
        public Guid AssetCategoryId { get; set; }
        public AssetCategory AssetCategory { get; set; } = null!;
        public Guid LocationId { get; set; }
        public Location Location { get; set; } = null!;
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; } = null!;
        public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();

        public Guid CompanyId { get; set; } //Tenant Key
        public Company Company { get; set; } = null!;
    }
}

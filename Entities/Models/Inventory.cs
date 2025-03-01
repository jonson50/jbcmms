using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid SparePartId { get; set; }
        public SparePart SparePart { get; set; } = null!;
        public int Quantity { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}

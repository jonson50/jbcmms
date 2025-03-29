using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Asset> Assets { get; set; } = new List<Asset>();
        public ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
        public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
    }
}

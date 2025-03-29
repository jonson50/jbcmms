using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities.Models
{
    public class WorkOrder
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Open;
        public ICollection<WorkOrderAssignment> Assignments { get; set; } = new List<WorkOrderAssignment>();
        public ICollection<SparePart> SpareParts { get; set; } = new List<SparePart>();

        public Guid CompanyId { get; set; } //Tenant Key
        public Company Company { get; set; } = null!;
    }
}

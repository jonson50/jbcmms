using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FailureReport
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
        public string IssueDescription { get; set; } = string.Empty;
        public DateTime ReportedDate { get; set; }
        public Guid? WorkOrderId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class MaintenanceSchedule
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
        public DateTime NextMaintenanceDate { get; set; }
        public int FrequencyInDays { get; set; }
    }
}

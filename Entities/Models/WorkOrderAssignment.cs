﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class WorkOrderAssignment
    {
        public Guid Id { get; set; }
        public Guid WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime AssignedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAssetRepository Asset { get; }
        IAssetCategoryRepository AssetCategory { get; }
        IFailureReportRepository FailureReport { get; }
        IInventoryRepository Inventory { get; }
        ILocationRepository Location { get; }
        IMaintenanceScheduleRepository MaintenanceSchedule { get; }
        IRoleRepository Role { get; }
        ISparePartRepository SparePart { get; }
        ISupplierRepository Supplier { get; }
        IUserRepository User { get; }
        IWorkOrderRepository WorkOrder { get; }
        IWorkOrderAssignmentRepository WorkOrderAssignment { get; }
        void Save();
    }
}

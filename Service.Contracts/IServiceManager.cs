using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IAssetCategoryService AssetCategoryService { get; }
        IAssetService AssetService { get; } 
        IFailureReportService FailureReportService { get; }
        IInventoryService InventoryService { get; }
        ILocationService LocationService { get; }
        IMaintenanceScheduleService MaintenanceScheduleService { get; }
        IRoleService RoleService { get; }
        ISparePartService SparePartService { get; }
        ISupplierService SupplierService { get; }
        IWorkOrderAssignmentService WorkOrderAssignmentService { get; }
        IWorkOrderService WorkOrderService { get; }
    }
}

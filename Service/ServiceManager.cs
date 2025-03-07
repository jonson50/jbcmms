using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAssetCategoryService> _assetCategoryService;
        private readonly Lazy<IAssetService> _assetService;
        private readonly Lazy<IFailureReportService> _failureReportService;
        private readonly Lazy<IInventoryService> _inventoryService;
        private readonly Lazy<ILocationService> _locationService;
        private readonly Lazy<IMaintenanceScheduleService> _maintenanceScheduleService;
        private readonly Lazy<IRoleService> _roleService;
        private readonly Lazy<ISparePartService> _sparePartService;
        private readonly Lazy<ISupplierService> _supplierService;
        private readonly Lazy<IWorkOrderAssignmentService> _workOrderAssignmentService;
        private readonly Lazy<IWorkOrderService> _workOrderService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
            _assetCategoryService = new Lazy<IAssetCategoryService>(() => new AssetCategoryService(repositoryManager, logger, mapper));
            _assetService = new Lazy<IAssetService>(() => new AssetService(repositoryManager, logger, mapper));
            _failureReportService = new Lazy<IFailureReportService>(() => new FailureReportService(repositoryManager, logger, mapper));
            _inventoryService = new Lazy<IInventoryService>(() => new InventoryService(repositoryManager, logger, mapper));
            _locationService = new Lazy<ILocationService>(() => new LocationService(repositoryManager, logger, mapper));
            _maintenanceScheduleService = new Lazy<IMaintenanceScheduleService>(() => new MaintenanceScheduleService(repositoryManager, logger, mapper));
            _roleService = new Lazy<IRoleService>(() => new RoleService(repositoryManager, logger, mapper));
            _sparePartService = new Lazy<ISparePartService>(() => new SparePartService(repositoryManager, logger, mapper));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager, logger, mapper));
            _workOrderAssignmentService = new Lazy<IWorkOrderAssignmentService>(() => new WorkOrderAssignmentService(repositoryManager, logger, mapper));
            _workOrderService = new Lazy<IWorkOrderService>(() => new WorkOrderService(repositoryManager, logger, mapper));
        }
        public IUserService UserService => _userService.Value;

        public IAssetCategoryService AssetCategoryService => _assetCategoryService.Value;

        public IAssetService AssetService => _assetService.Value;

        public IFailureReportService FailureReportService => _failureReportService.Value;

        public IInventoryService InventoryService => _inventoryService.Value;

        public ILocationService LocationService => _locationService.Value;

        public IMaintenanceScheduleService MaintenanceScheduleService => _maintenanceScheduleService.Value;

        public IRoleService RoleService => _roleService.Value;

        public ISparePartService SparePartService => _sparePartService.Value;

        public ISupplierService SupplierService => _supplierService.Value;

        public IWorkOrderAssignmentService WorkOrderAssignmentService => _workOrderAssignmentService.Value;

        public IWorkOrderService WorkOrderService => _workOrderService.Value;
    }
}

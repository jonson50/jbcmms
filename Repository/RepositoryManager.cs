using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAssetRepository> _assetRepository;
        private readonly Lazy<IAssetCategoryRepository> _assetCategoryRepository;
        private readonly Lazy<IFailureReportRepository> _failureReportRepository;
        private readonly Lazy<IInventoryRepository> _inventoryRepository;
        private readonly Lazy<ILocationRepository> _locationRepository;
        private readonly Lazy<IMaintenanceScheduleRepository> _maintenanceScheduleRepository;
        private readonly Lazy<IRoleRepository> _roleRepository;
        private readonly Lazy<ISparePartRepository> _sparePartRepository;
        private readonly Lazy<ISupplierRepository> _supplierRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IWorkOrderRepository> _workOrderRepository;
        private readonly Lazy<IWorkOrderAssignmentRepository> _workOrderAssignmentRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _assetRepository = new Lazy<IAssetRepository>(() => new AssetRepository(_repositoryContext));
            _assetCategoryRepository = new Lazy<IAssetCategoryRepository>(() => new AssetCategoryRepository(_repositoryContext));
            _failureReportRepository = new Lazy<IFailureReportRepository>(() => new FailureReportRepository(_repositoryContext));
            _inventoryRepository = new Lazy<IInventoryRepository>(() => new InventoryRepository(_repositoryContext));
            _locationRepository = new Lazy<ILocationRepository>(() => new LocationRepository(_repositoryContext));
            _maintenanceScheduleRepository = new Lazy<IMaintenanceScheduleRepository>(() => new MaintenanceScheduleRepository(_repositoryContext));
            _roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(_repositoryContext));
            _sparePartRepository = new Lazy<ISparePartRepository>(() => new SparePartRepository(_repositoryContext));
            _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(_repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
            _workOrderRepository = new Lazy<IWorkOrderRepository>(() => new WorkOrderRepository(_repositoryContext));
            _workOrderAssignmentRepository = new Lazy<IWorkOrderAssignmentRepository>(() => new WorkOrderAssignmentRepository(_repositoryContext));
        }

        public IAssetRepository Asset => _assetRepository.Value;

        public IAssetCategoryRepository AssetCategory => _assetCategoryRepository.Value;

        public IFailureReportRepository FailureReport => _failureReportRepository.Value;

        public IInventoryRepository Inventory => _inventoryRepository.Value;

        public ILocationRepository Location => _locationRepository.Value;

        public IMaintenanceScheduleRepository MaintenanceSchedule => _maintenanceScheduleRepository.Value;

        public IRoleRepository Role => _roleRepository.Value;

        public ISparePartRepository SparePart => _sparePartRepository.Value;

        public ISupplierRepository Supplier => _supplierRepository.Value;

        public IUserRepository User => _userRepository.Value;

        public IWorkOrderRepository WorkOrder => _workOrderRepository.Value;

        public IWorkOrderAssignmentRepository WorkOrderAssignment => _workOrderAssignmentRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}

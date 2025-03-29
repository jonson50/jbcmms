using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new AssetCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AssetConfiguration());
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }
        public DbSet<FailureReport> FailureReports { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MaintenanceSchedule> MaintenanceSchedules { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderAssignment> WorkOrderAssignments { get; set; } 
    }
}

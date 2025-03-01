﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace jbcmms.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20250301125303_AssetLocationSupplier")]
    partial class AssetLocationSupplier
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssetCategoryId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Entities.Models.AssetCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90696613-f797-40b0-aa23-84220db0403e"),
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"),
                            Name = "Another Category"
                        });
                });

            modelBuilder.Entity("Entities.Models.FailureReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IssueDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("FailureReports");
                });

            modelBuilder.Entity("Entities.Models.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SparePartId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SparePartId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Entities.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"),
                            Address = "1234 Example St.",
                            Name = "Dummy Location"
                        },
                        new
                        {
                            Id = new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"),
                            Address = "5678 Test St.",
                            Name = "Another Location"
                        });
                });

            modelBuilder.Entity("Entities.Models.MaintenanceSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FrequencyInDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NextMaintenanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("MaintenanceSchedules");
                });

            modelBuilder.Entity("Entities.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Entities.Models.SparePart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SpareParts");
                });

            modelBuilder.Entity("Entities.Models.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22"),
                            ContactPerson = "John Doe",
                            Email = "john.doe@example.com",
                            Name = "Dummy Supplier",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516"),
                            ContactPerson = "Jane Doe",
                            Email = "jane@mail.com",
                            Name = "Another Supplier",
                            Phone = "098-765-4321"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.WorkOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("Entities.Models.WorkOrderAssignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("WorkOrderAssignments");
                });

            modelBuilder.Entity("SparePartWorkOrder", b =>
                {
                    b.Property<Guid>("SparePartsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkOrdersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SparePartsId", "WorkOrdersId");

                    b.HasIndex("WorkOrdersId");

                    b.ToTable("SparePartWorkOrder");
                });

            modelBuilder.Entity("Entities.Models.Asset", b =>
                {
                    b.HasOne("Entities.Models.AssetCategory", "AssetCategory")
                        .WithMany("Assets")
                        .HasForeignKey("AssetCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Location", "Location")
                        .WithMany("Assets")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Supplier", "Supplier")
                        .WithMany("Assets")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetCategory");

                    b.Navigation("Location");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Entities.Models.FailureReport", b =>
                {
                    b.HasOne("Entities.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.WorkOrder", "WorkOrder")
                        .WithMany()
                        .HasForeignKey("WorkOrderId");

                    b.Navigation("Asset");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("Entities.Models.Inventory", b =>
                {
                    b.HasOne("Entities.Models.SparePart", "SparePart")
                        .WithMany()
                        .HasForeignKey("SparePartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SparePart");
                });

            modelBuilder.Entity("Entities.Models.MaintenanceSchedule", b =>
                {
                    b.HasOne("Entities.Models.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Models.WorkOrder", b =>
                {
                    b.HasOne("Entities.Models.Asset", "Asset")
                        .WithMany("WorkOrders")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("Entities.Models.WorkOrderAssignment", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.WorkOrder", "WorkOrder")
                        .WithMany("Assignments")
                        .HasForeignKey("WorkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("SparePartWorkOrder", b =>
                {
                    b.HasOne("Entities.Models.SparePart", null)
                        .WithMany()
                        .HasForeignKey("SparePartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.WorkOrder", null)
                        .WithMany()
                        .HasForeignKey("WorkOrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Asset", b =>
                {
                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("Entities.Models.AssetCategory", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Entities.Models.Location", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Entities.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Models.Supplier", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Entities.Models.WorkOrder", b =>
                {
                    b.Navigation("Assignments");
                });
#pragma warning restore 612, 618
        }
    }
}

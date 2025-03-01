using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData
            (
                new Supplier
                {
                    Id = new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22"),
                    Name = "Dummy Supplier",
                    ContactPerson = "John Doe",
                    Email = "john.doe@example.com",
                    Phone = "123-456-7890",
                },
                new Supplier
                {
                    Id = new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516"),
                    Name = "Another Supplier",
                    ContactPerson = "Jane Doe",
                    Email = "jane@mail.com",
                    Phone = "098-765-4321",
                }
            );
        }
    }
}

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
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
                new Company
                {
                    Id = new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c12"),
                    Name = "Dummy Company",
                    Industry = "Software",
                    Address = "1234 Elm St, Springfield, IL 62701",
                },
                new Company
                {
                    Id = new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516"),
                    Name = "Another Company",
                    Industry = "Hardware",
                    Address = "5678 Oak St, Springfield, IL 62702",
                }
            );
        }
    }
}

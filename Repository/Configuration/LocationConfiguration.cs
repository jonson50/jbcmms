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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData
            (
                new Location
                {
                    Id = new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"),
                    Name = "Dummy Location",
                    Address = "1234 Example St.",
                },
                new Location
                {
                    Id = new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"),
                    Name = "Another Location",
                    Address = "5678 Test St.",
                }
            );
        }
    }
}

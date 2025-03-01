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
    public class AssetCategoryConfiguration : IEntityTypeConfiguration<AssetCategory>
    {
        public void Configure(EntityTypeBuilder<AssetCategory> builder)
        {
            builder.HasData
            (
                new AssetCategory
                {
                    Id = new Guid("90696613-f797-40b0-aa23-84220db0403e"),
                    Name = "Category 1",
                },
                new AssetCategory
                {
                    Id = new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"),
                    Name = "Another Category",
                }
            );
        }
    }
}

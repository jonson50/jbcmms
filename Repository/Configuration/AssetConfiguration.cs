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
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasData
                (
                    new Asset
                    {
                        Id = new Guid("5c439755-fb1f-4a35-82ed-6fabe23e90a5"),
                        Name = "Dummy Asset",
                        SerialNumber = "123456789",
                        PurchaseDate = new DateTime(2021, 1, 1),
                        AssetCategoryId = new Guid("90696613-f797-40b0-aa23-84220db0403e"),
                        LocationId = new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"),
                        SupplierId = new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22")
                    },
                    new Asset
                    {
                        Id = new Guid("345f7ea5-fd38-4706-8c28-4ca25bd5d11b"),
                        Name = "Asset 2",
                        SerialNumber = "456789",
                        PurchaseDate = new DateTime(2021, 1, 1),
                        AssetCategoryId = new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"),
                        LocationId = new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"),
                        SupplierId = new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516")
                    }
                );
        }
    }
}

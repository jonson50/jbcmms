using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace jbcmms.Migrations
{
    /// <inheritdoc />
    public partial class AssetData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetCategoryId", "LocationId", "Name", "PurchaseDate", "SerialNumber", "SupplierId" },
                values: new object[,]
                {
                    { new Guid("345f7ea5-fd38-4706-8c28-4ca25bd5d11b"), new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"), new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"), "Asset 2", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516") },
                    { new Guid("5c439755-fb1f-4a35-82ed-6fabe23e90a5"), new Guid("90696613-f797-40b0-aa23-84220db0403e"), new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"), "Dummy Asset", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("345f7ea5-fd38-4706-8c28-4ca25bd5d11b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("5c439755-fb1f-4a35-82ed-6fabe23e90a5"));
        }
    }
}

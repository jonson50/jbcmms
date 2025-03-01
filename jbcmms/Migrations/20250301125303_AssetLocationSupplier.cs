using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace jbcmms.Migrations
{
    /// <inheritdoc />
    public partial class AssetLocationSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("a2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"));

            migrationBuilder.InsertData(
                table: "AssetCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("90696613-f797-40b0-aa23-84220db0403e"), "Category 1" },
                    { new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"), "Another Category" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"), "1234 Example St.", "Dummy Location" },
                    { new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"), "5678 Test St.", "Another Location" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "ContactPerson", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516"), "Jane Doe", "jane@mail.com", "Another Supplier", "098-765-4321" },
                    { new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22"), "John Doe", "john.doe@example.com", "Dummy Supplier", "123-456-7890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetCategories",
                keyColumn: "Id",
                keyValue: new Guid("90696613-f797-40b0-aa23-84220db0403e"));

            migrationBuilder.DeleteData(
                table: "AssetCategories",
                keyColumn: "Id",
                keyValue: new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("14555dc6-b4c4-4f9b-8169-9c7acd481320"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("3c92b091-b435-4bd7-9187-edfe7084d04e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("0f57cd75-67b3-4e09-8ed8-9fad1f5c8516"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("f59b65d3-77c6-48dc-82e0-2f704e3e0c22"));

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "ContactPerson", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("a2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"), "John Doe", "john.doe@example.com", "Dummy Supplier", "123-456-7890" },
                    { new Guid("b2c4f4e0-4b6d-4b4f-8b8e-2f3b6f4b9e1d"), "Jane Doe", "jane@mail.com", "Another Supplier", "098-765-4321" }
                });
        }
    }
}

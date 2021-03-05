using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StorageNA21.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "Mobile", 156, "Stupid", "Iphone", new DateTime(2021, 2, 27, 11, 4, 7, 715, DateTimeKind.Local).AddTicks(6522), 15600, "4B" },
                    { 2, "Mobile", 98, "Better", "S10", new DateTime(2021, 2, 10, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9829), 12450, "4C" },
                    { 3, "Computers", 23, "Stupid", "MacBook", new DateTime(2021, 2, 28, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9879), 45600, "4C" },
                    { 4, "Computer", 32, "Stupid", "Suface X", new DateTime(2021, 1, 24, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9884), 26850, "5C" },
                    { 5, "Office Supplies", 15651, "Stupid", "Pen", new DateTime(2021, 2, 27, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9887), 1, "45W" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

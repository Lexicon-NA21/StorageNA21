using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StorageNA21.Migrations
{
    public partial class DataAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 2, 27, 11, 19, 29, 569, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2021, 2, 10, 11, 19, 29, 571, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2021, 2, 28, 11, 19, 29, 571, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2021, 1, 24, 11, 19, 29, 571, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2021, 2, 27, 11, 19, 29, 571, DateTimeKind.Local).AddTicks(5773));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 2, 27, 11, 4, 7, 715, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2021, 2, 10, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2021, 2, 28, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2021, 1, 24, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2021, 2, 27, 11, 4, 7, 718, DateTimeKind.Local).AddTicks(9887));
        }
    }
}

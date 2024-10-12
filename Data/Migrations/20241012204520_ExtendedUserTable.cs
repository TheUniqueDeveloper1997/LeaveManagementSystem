using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d87a20d5-4d1f-401d-9b8b-0d7242079d43", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEMmP/tWanLcDlou5InjW+a/pwJEU2EGPLMJQoVOQTrWvA0iXZiQqop8/hLaJb0hpoA==", "1252ecec-3e56-4ad0-b0e3-40d238e3b2fe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade34f30-c875-483d-807a-6dd33dab2244", "AQAAAAIAAYagAAAAEIeLT/U43DJ0WBwyEas4vyb8E0w5iXQU8vmK00iWnaJOAfzrOCVVoK2A0XBf/Yd/Jw==", "a2f82ac6-838e-49b5-bbc2-24c1b89aac84" });
        }
    }
}

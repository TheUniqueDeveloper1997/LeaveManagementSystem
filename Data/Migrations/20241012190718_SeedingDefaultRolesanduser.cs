using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesanduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95df01df-0207-4e91-8317-5ca19706d6d7", null, "Employee", "EMPLOYEE" },
                    { "a52d797b-d8a4-4cc3-a52b-8b56628f7925", null, "Administrator", "ADMINISTRATOR" },
                    { "e86df6b4-4cbf-49b5-a9c3-d4476ca8a5b3", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a", 0, "ade34f30-c875-483d-807a-6dd33dab2244", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIeLT/U43DJ0WBwyEas4vyb8E0w5iXQU8vmK00iWnaJOAfzrOCVVoK2A0XBf/Yd/Jw==", null, false, "a2f82ac6-838e-49b5-bbc2-24c1b89aac84", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a52d797b-d8a4-4cc3-a52b-8b56628f7925", "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95df01df-0207-4e91-8317-5ca19706d6d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86df6b4-4cbf-49b5-a9c3-d4476ca8a5b3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a52d797b-d8a4-4cc3-a52b-8b56628f7925", "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52d797b-d8a4-4cc3-a52b-8b56628f7925");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9dc2b8-239a-41c8-a9e9-7913048d8a5a");
        }
    }
}

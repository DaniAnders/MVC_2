using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class UserAndAdminRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5014a1df-5a8f-4464-adfc-4f2127c1345e", "12f388b1-dd61-4e5f-8eed-d3bf47c512e8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b493b149-e658-4661-9d13-9ad721627508", "5c6c106c-a027-4577-8a1e-49f455a91514", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "58d7f839-38b9-4a74-a80e-6c770bc6499f", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "701dd361-c6de-4c0c-aefc-523496e3f061", "admin@admin.com", false, "Administrator", "System Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJN1+tBF7cxjlmrrYskvnoNRfBEEXu33kRwX98NEWdV2SLMUAtrHsV7+V6RzapqF4A==", null, false, "800101", "51db9b76-815d-49cc-a140-20ba436f1d5e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b493b149-e658-4661-9d13-9ad721627508", "58d7f839-38b9-4a74-a80e-6c770bc6499f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5014a1df-5a8f-4464-adfc-4f2127c1345e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b493b149-e658-4661-9d13-9ad721627508", "58d7f839-38b9-4a74-a80e-6c770bc6499f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b493b149-e658-4661-9d13-9ad721627508");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58d7f839-38b9-4a74-a80e-6c770bc6499f");
        }
    }
}

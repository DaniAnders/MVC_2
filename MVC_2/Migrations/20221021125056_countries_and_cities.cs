using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class countries_and_cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d0c8185-135f-4fd6-a958-28715bc2d885");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3fc8b3b0-2041-462b-a52a-4b792c9ab472", "c58a5a9e-7659-42a3-b8c5-95656f582c7e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fc8b3b0-2041-462b-a52a-4b792c9ab472");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58a5a9e-7659-42a3-b8c5-95656f582c7e");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { new Guid("24d8134f-095c-494d-aa52-232aaf7d048d"), "Norway" },
                    { new Guid("3bdc6022-b967-46b1-b59d-fdd05d33a400"), "France" },
                    { new Guid("50ff5c9a-0d08-4e67-8004-f6d3add21a11"), "Denmark" },
                    { new Guid("b7689781-0e5a-47b8-ae22-fa1b16716046"), "Italy" },
                    { new Guid("ca6ec064-3838-416c-a4ec-04860b5538e1"), "Portugal" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { new Guid("21e72345-aaa1-4ec7-8c47-73858a70617c"), "Oslo", new Guid("24d8134f-095c-494d-aa52-232aaf7d048d") },
                    { new Guid("32719727-c1c9-4823-bacb-6cc31654c109"), "Paris", new Guid("3bdc6022-b967-46b1-b59d-fdd05d33a400") },
                    { new Guid("37bbb0db-ddbe-40e9-8bbc-8f62c83bb298"), "Dijon", new Guid("3bdc6022-b967-46b1-b59d-fdd05d33a400") },
                    { new Guid("3e5a7d8f-1421-44f7-ada1-6fb7a987f6a8"), "Braga", new Guid("ca6ec064-3838-416c-a4ec-04860b5538e1") },
                    { new Guid("4bed78b1-50b8-45ce-a1ac-88f2a944a143"), "Porto", new Guid("ca6ec064-3838-416c-a4ec-04860b5538e1") },
                    { new Guid("5e1ca805-9454-4269-ad44-bd1052bfd8d2"), "Guimaraes", new Guid("ca6ec064-3838-416c-a4ec-04860b5538e1") },
                    { new Guid("9073ec84-94e4-41b6-bbb0-c21f28c72366"), "Florence", new Guid("b7689781-0e5a-47b8-ae22-fa1b16716046") },
                    { new Guid("9f3d06c1-3bc2-4b57-a2ad-f84b314e2f8f"), "Trondheim", new Guid("24d8134f-095c-494d-aa52-232aaf7d048d") },
                    { new Guid("afe4e43b-30f9-4fd8-b1dc-d911846f727d"), "Copenhagen", new Guid("50ff5c9a-0d08-4e67-8004-f6d3add21a11") },
                    { new Guid("b2904d2a-56b4-4fdc-9611-0c7524c1b1b5"), "Venice", new Guid("b7689781-0e5a-47b8-ae22-fa1b16716046") },
                    { new Guid("d8e598b4-c9e8-435c-881d-51e99ebc81ec"), "Bergen", new Guid("24d8134f-095c-494d-aa52-232aaf7d048d") },
                    { new Guid("df6c52e6-4461-4e1e-ae2a-a5e4f0fa3f0b"), "Aarhus", new Guid("50ff5c9a-0d08-4e67-8004-f6d3add21a11") },
                    { new Guid("ed3e6d14-be02-4d51-85cd-fa737efd032d"), "Annecy", new Guid("3bdc6022-b967-46b1-b59d-fdd05d33a400") },
                    { new Guid("ee96226b-619f-4d8e-bb9e-c77378b8ee4d"), "Odense ", new Guid("50ff5c9a-0d08-4e67-8004-f6d3add21a11") },
                    { new Guid("fdfa3b16-3578-4cb0-a13f-e26855927026"), "Rome", new Guid("b7689781-0e5a-47b8-ae22-fa1b16716046") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("21e72345-aaa1-4ec7-8c47-73858a70617c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("32719727-c1c9-4823-bacb-6cc31654c109"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("37bbb0db-ddbe-40e9-8bbc-8f62c83bb298"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3e5a7d8f-1421-44f7-ada1-6fb7a987f6a8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4bed78b1-50b8-45ce-a1ac-88f2a944a143"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5e1ca805-9454-4269-ad44-bd1052bfd8d2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9073ec84-94e4-41b6-bbb0-c21f28c72366"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9f3d06c1-3bc2-4b57-a2ad-f84b314e2f8f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("afe4e43b-30f9-4fd8-b1dc-d911846f727d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b2904d2a-56b4-4fdc-9611-0c7524c1b1b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d8e598b4-c9e8-435c-881d-51e99ebc81ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("df6c52e6-4461-4e1e-ae2a-a5e4f0fa3f0b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ed3e6d14-be02-4d51-85cd-fa737efd032d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ee96226b-619f-4d8e-bb9e-c77378b8ee4d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdfa3b16-3578-4cb0-a13f-e26855927026"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24d8134f-095c-494d-aa52-232aaf7d048d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3bdc6022-b967-46b1-b59d-fdd05d33a400"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50ff5c9a-0d08-4e67-8004-f6d3add21a11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7689781-0e5a-47b8-ae22-fa1b16716046"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca6ec064-3838-416c-a4ec-04860b5538e1"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3fc8b3b0-2041-462b-a52a-4b792c9ab472", "dbbdf033-5ae8-4e1a-9191-bf5a8df99388", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d0c8185-135f-4fd6-a958-28715bc2d885", "4d9635fd-d0f1-4805-9ce0-86798ea59b10", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c58a5a9e-7659-42a3-b8c5-95656f582c7e", 0, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2a6c6f4a-e411-4f99-942f-af1fb463eb57", "admin@admin.com", false, "Administrator", "System Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEI9q3iHTTkQe4vAWcDw1kjpPOj7DcdEI5U8QYb1f68SrT9xxN7YGG2EE2Rj20MbWsg==", null, false, "800101", "43a67c1b-4cbe-4e18-aa9a-3a12ec28381e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3fc8b3b0-2041-462b-a52a-4b792c9ab472", "c58a5a9e-7659-42a3-b8c5-95656f582c7e" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { new Guid("065ec27c-de0c-49da-8a1a-50158483012a"), "Italian" },
                    { new Guid("289ad2e1-a339-4b63-b588-a2809a28e7fd"), "French" },
                    { new Guid("522a4c71-c69b-488a-a1d9-8227362c35b9"), "Portuguese" },
                    { new Guid("5757e458-a901-4a65-b6d5-a7e16683e7aa"), "Swedish" },
                    { new Guid("80f98112-2a66-440f-bf30-63bf99161af0"), "Japanese" },
                    { new Guid("de34bd26-352c-4d6e-8a7f-ee8a513668c4"), "English" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("065ec27c-de0c-49da-8a1a-50158483012a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("289ad2e1-a339-4b63-b588-a2809a28e7fd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("522a4c71-c69b-488a-a1d9-8227362c35b9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("5757e458-a901-4a65-b6d5-a7e16683e7aa"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("80f98112-2a66-440f-bf30-63bf99161af0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("de34bd26-352c-4d6e-8a7f-ee8a513668c4"));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class people : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("0e1f92dd-da6f-4155-b910-3ac8e551ce32"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1141524b-01b0-4d00-920b-4ce5d9c1c424"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1851eac0-b554-40f9-a57d-3fb1dddb72c8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2f739800-df32-40ac-a7a4-a1aa348c8377"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("42592ce8-c7ef-4f92-b4ae-b55f9448e8d8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ad19b6a-a864-4343-bcaa-558b72e0e164"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("562e2dc0-13b8-4626-8a69-89c43f8e3aa7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("95174af2-f124-4253-b976-f26c5b4f32dd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a18f10e6-fe37-4d7f-b808-31a60635a535"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a484d232-3e53-491e-8037-4a2f32154e53"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a6e0219a-6fd8-467f-b623-bbcda7a1b16c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b5c6b95e-956e-40ce-88d4-6f3f9e00341c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c481b64e-6c7e-47f5-905e-b37c76ef93b5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb30af85-9f6c-4b2f-8edf-18fbfb517f29"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f7ea6182-727f-4833-8c9e-9f3d02aa4ee0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("5b8c0ddb-f7fd-4838-aec1-1e3a7227d45e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("714e510a-26e0-476c-bc3b-13d28e9f66db"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("7740c113-82e7-44ef-ae59-74dd919bb486"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("81f18c56-062c-4e11-92eb-0f744ffb6e46"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("9bf292d4-c217-4320-8822-0af22a2826a3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("ea641806-9e02-4823-9c52-fe75da5b94a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("131ac8a6-49f1-4717-be0a-262d9ca4ac0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("263148f6-5417-4328-b45b-8c391e7cb105"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("38c35795-4019-4e84-8ee9-95b2adda6b3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("505b9769-c390-438e-9079-71de58b38b94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60d18e10-566d-425b-b420-d1bef60a1e6e"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { new Guid("2f11db28-3bc2-4fdf-ae9f-3936c13d449d"), "Norway" },
                    { new Guid("4b044c1b-0368-471a-bf78-ac7a73907878"), "France" },
                    { new Guid("566df772-39de-4b14-aff5-e1724b2572db"), "Italy" },
                    { new Guid("95074062-82ab-4386-ae29-1b0688d6c346"), "Portugal" },
                    { new Guid("bde65108-e5c4-4188-b4b1-f794ee3c46e6"), "Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { new Guid("3897cf17-997a-4c4a-a300-6a58efaf5abf"), "Swedish" },
                    { new Guid("5667b130-9844-4d08-bbbf-de4303592ca1"), "English" },
                    { new Guid("7066d2e4-4896-4396-abfc-3cc7707e2d41"), "Italian" },
                    { new Guid("77a4e8eb-ac80-4324-8574-446fe62e06f5"), "French" },
                    { new Guid("816b61b9-6009-4d43-83b8-f37133c79c0c"), "Portuguese" },
                    { new Guid("c2e8e20a-c417-4cd7-8e45-a4664ee70e16"), "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { new Guid("11b59f07-bb2c-4b6d-8653-a318f44ba453"), "Bergen", new Guid("2f11db28-3bc2-4fdf-ae9f-3936c13d449d") },
                    { new Guid("3cfa2b76-ab90-464f-b0b3-7faadc27df1b"), "Dijon", new Guid("4b044c1b-0368-471a-bf78-ac7a73907878") },
                    { new Guid("673ebbc2-6b9e-4932-ab08-07957647ce7e"), "Braga", new Guid("95074062-82ab-4386-ae29-1b0688d6c346") },
                    { new Guid("7f3f8027-726c-4315-917b-6f1931168cfa"), "Guimaraes", new Guid("95074062-82ab-4386-ae29-1b0688d6c346") },
                    { new Guid("944d0e71-a2f1-449d-9584-4ba111318379"), "Copenhagen", new Guid("bde65108-e5c4-4188-b4b1-f794ee3c46e6") },
                    { new Guid("99bae452-e123-4b02-8deb-4cfc5d886610"), "Florence", new Guid("566df772-39de-4b14-aff5-e1724b2572db") },
                    { new Guid("a8048249-862b-42b8-8f2d-a84c6ec13e2a"), "Rome", new Guid("566df772-39de-4b14-aff5-e1724b2572db") },
                    { new Guid("c4ce767a-710f-4f62-af9b-28d7f856e5ad"), "Trondheim", new Guid("2f11db28-3bc2-4fdf-ae9f-3936c13d449d") },
                    { new Guid("ccb66972-c208-4534-9494-9e9be7a565c7"), "Porto", new Guid("95074062-82ab-4386-ae29-1b0688d6c346") },
                    { new Guid("cf32e01b-6015-45bf-acb0-8af93cfda3ec"), "Paris", new Guid("4b044c1b-0368-471a-bf78-ac7a73907878") },
                    { new Guid("daf7f6b0-8839-4cc3-999e-43464dd59b48"), "Oslo", new Guid("2f11db28-3bc2-4fdf-ae9f-3936c13d449d") },
                    { new Guid("e6a0ef7b-5251-4615-a392-b3931a51917d"), "Venice", new Guid("566df772-39de-4b14-aff5-e1724b2572db") },
                    { new Guid("fb9190e7-58ea-4328-aab3-2dbd858b3dcd"), "Odense ", new Guid("bde65108-e5c4-4188-b4b1-f794ee3c46e6") },
                    { new Guid("fd91f6ed-5c36-43e7-9450-b3d9ceec59bb"), "Aarhus", new Guid("bde65108-e5c4-4188-b4b1-f794ee3c46e6") },
                    { new Guid("fdf4420f-bc72-40b9-be12-7dca23d3f780"), "Annecy", new Guid("4b044c1b-0368-471a-bf78-ac7a73907878") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("11b59f07-bb2c-4b6d-8653-a318f44ba453"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3cfa2b76-ab90-464f-b0b3-7faadc27df1b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("673ebbc2-6b9e-4932-ab08-07957647ce7e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7f3f8027-726c-4315-917b-6f1931168cfa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("944d0e71-a2f1-449d-9584-4ba111318379"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("99bae452-e123-4b02-8deb-4cfc5d886610"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a8048249-862b-42b8-8f2d-a84c6ec13e2a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c4ce767a-710f-4f62-af9b-28d7f856e5ad"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ccb66972-c208-4534-9494-9e9be7a565c7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cf32e01b-6015-45bf-acb0-8af93cfda3ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("daf7f6b0-8839-4cc3-999e-43464dd59b48"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e6a0ef7b-5251-4615-a392-b3931a51917d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fb9190e7-58ea-4328-aab3-2dbd858b3dcd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fd91f6ed-5c36-43e7-9450-b3d9ceec59bb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fdf4420f-bc72-40b9-be12-7dca23d3f780"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("3897cf17-997a-4c4a-a300-6a58efaf5abf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("5667b130-9844-4d08-bbbf-de4303592ca1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("7066d2e4-4896-4396-abfc-3cc7707e2d41"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("77a4e8eb-ac80-4324-8574-446fe62e06f5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("816b61b9-6009-4d43-83b8-f37133c79c0c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("c2e8e20a-c417-4cd7-8e45-a4664ee70e16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f11db28-3bc2-4fdf-ae9f-3936c13d449d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b044c1b-0368-471a-bf78-ac7a73907878"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("566df772-39de-4b14-aff5-e1724b2572db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95074062-82ab-4386-ae29-1b0688d6c346"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bde65108-e5c4-4188-b4b1-f794ee3c46e6"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { new Guid("131ac8a6-49f1-4717-be0a-262d9ca4ac0c"), "Denmark" },
                    { new Guid("263148f6-5417-4328-b45b-8c391e7cb105"), "Portugal" },
                    { new Guid("38c35795-4019-4e84-8ee9-95b2adda6b3b"), "France" },
                    { new Guid("505b9769-c390-438e-9079-71de58b38b94"), "Italy" },
                    { new Guid("60d18e10-566d-425b-b420-d1bef60a1e6e"), "Norway" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { new Guid("5b8c0ddb-f7fd-4838-aec1-1e3a7227d45e"), "Japanese" },
                    { new Guid("714e510a-26e0-476c-bc3b-13d28e9f66db"), "Swedish" },
                    { new Guid("7740c113-82e7-44ef-ae59-74dd919bb486"), "English" },
                    { new Guid("81f18c56-062c-4e11-92eb-0f744ffb6e46"), "French" },
                    { new Guid("9bf292d4-c217-4320-8822-0af22a2826a3"), "Italian" },
                    { new Guid("ea641806-9e02-4823-9c52-fe75da5b94a8"), "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { new Guid("0e1f92dd-da6f-4155-b910-3ac8e551ce32"), "Guimaraes", new Guid("263148f6-5417-4328-b45b-8c391e7cb105") },
                    { new Guid("1141524b-01b0-4d00-920b-4ce5d9c1c424"), "Copenhagen", new Guid("131ac8a6-49f1-4717-be0a-262d9ca4ac0c") },
                    { new Guid("1851eac0-b554-40f9-a57d-3fb1dddb72c8"), "Rome", new Guid("505b9769-c390-438e-9079-71de58b38b94") },
                    { new Guid("2f739800-df32-40ac-a7a4-a1aa348c8377"), "Aarhus", new Guid("131ac8a6-49f1-4717-be0a-262d9ca4ac0c") },
                    { new Guid("42592ce8-c7ef-4f92-b4ae-b55f9448e8d8"), "Venice", new Guid("505b9769-c390-438e-9079-71de58b38b94") },
                    { new Guid("4ad19b6a-a864-4343-bcaa-558b72e0e164"), "Trondheim", new Guid("60d18e10-566d-425b-b420-d1bef60a1e6e") },
                    { new Guid("562e2dc0-13b8-4626-8a69-89c43f8e3aa7"), "Odense ", new Guid("131ac8a6-49f1-4717-be0a-262d9ca4ac0c") },
                    { new Guid("95174af2-f124-4253-b976-f26c5b4f32dd"), "Porto", new Guid("263148f6-5417-4328-b45b-8c391e7cb105") },
                    { new Guid("a18f10e6-fe37-4d7f-b808-31a60635a535"), "Annecy", new Guid("38c35795-4019-4e84-8ee9-95b2adda6b3b") },
                    { new Guid("a484d232-3e53-491e-8037-4a2f32154e53"), "Florence", new Guid("505b9769-c390-438e-9079-71de58b38b94") },
                    { new Guid("a6e0219a-6fd8-467f-b623-bbcda7a1b16c"), "Dijon", new Guid("38c35795-4019-4e84-8ee9-95b2adda6b3b") },
                    { new Guid("b5c6b95e-956e-40ce-88d4-6f3f9e00341c"), "Braga", new Guid("263148f6-5417-4328-b45b-8c391e7cb105") },
                    { new Guid("c481b64e-6c7e-47f5-905e-b37c76ef93b5"), "Bergen", new Guid("60d18e10-566d-425b-b420-d1bef60a1e6e") },
                    { new Guid("eb30af85-9f6c-4b2f-8edf-18fbfb517f29"), "Oslo", new Guid("60d18e10-566d-425b-b420-d1bef60a1e6e") },
                    { new Guid("f7ea6182-727f-4833-8c9e-9f3d02aa4ee0"), "Paris", new Guid("38c35795-4019-4e84-8ee9-95b2adda6b3b") }
                });
        }
    }
}

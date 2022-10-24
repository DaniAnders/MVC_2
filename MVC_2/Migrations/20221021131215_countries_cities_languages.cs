using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class countries_cities_languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

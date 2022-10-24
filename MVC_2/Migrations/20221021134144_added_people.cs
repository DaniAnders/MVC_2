using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class added_people : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4f5dc1f0-f5b9-4f90-b799-988cb233b1ae"), "Portugal" },
                    { new Guid("7245bba1-58c3-4937-883a-7786bf9f9436"), "France" },
                    { new Guid("759ddf47-ae2c-4c21-9351-96e1a535ee77"), "Italy" },
                    { new Guid("aa81fa10-b6bd-424d-a5e7-91ad930f489c"), "Norway" },
                    { new Guid("cca16ece-7f88-4143-9880-2273979b9b43"), "Denmark" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { new Guid("09406fcd-8e27-4b22-b56b-3e847425c19c"), "French" },
                    { new Guid("0eebf3d9-8f63-445f-8bf1-b787bd1a845d"), "English" },
                    { new Guid("66da974c-1034-41c3-b171-a3123e8afacf"), "Italian" },
                    { new Guid("c5077cff-374a-41de-85c9-a518ae0cd831"), "Portuguese" },
                    { new Guid("c960d0cc-cee7-4f2e-8b37-214eebf3159b"), "Swedish" },
                    { new Guid("e1dcbc18-faef-4dd5-9a49-aa24a4902c1d"), "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { new Guid("035145ec-3d05-4a92-ab28-46dc9e2d42b7"), "Venice", new Guid("759ddf47-ae2c-4c21-9351-96e1a535ee77") },
                    { new Guid("04c19d62-fad7-4671-8078-c9cbee3befa3"), "Guimaraes", new Guid("4f5dc1f0-f5b9-4f90-b799-988cb233b1ae") },
                    { new Guid("216494e4-bf95-4dda-b21e-3014c4746f6b"), "Copenhagen", new Guid("cca16ece-7f88-4143-9880-2273979b9b43") },
                    { new Guid("279df6bf-ba3e-4a5b-b1b3-3d6b1ffb7256"), "Paris", new Guid("7245bba1-58c3-4937-883a-7786bf9f9436") },
                    { new Guid("6bfd3991-eb10-45ef-b75c-9d845e69f7e8"), "Rome", new Guid("759ddf47-ae2c-4c21-9351-96e1a535ee77") },
                    { new Guid("70538a38-a1e6-4af3-bba6-e628f381e237"), "Porto", new Guid("4f5dc1f0-f5b9-4f90-b799-988cb233b1ae") },
                    { new Guid("7e18f369-3a77-409a-96b1-df200f459fc0"), "Trondheim", new Guid("aa81fa10-b6bd-424d-a5e7-91ad930f489c") },
                    { new Guid("a3ef5e79-81f9-429d-83e5-548a9da68d2a"), "Dijon", new Guid("7245bba1-58c3-4937-883a-7786bf9f9436") },
                    { new Guid("ab542424-4120-4301-a962-a089f7807d05"), "Braga", new Guid("4f5dc1f0-f5b9-4f90-b799-988cb233b1ae") },
                    { new Guid("b1ec0ce6-cf92-4833-b42f-0822236de1d8"), "Annecy", new Guid("7245bba1-58c3-4937-883a-7786bf9f9436") },
                    { new Guid("bc2d4d79-8078-49e8-9b1e-5bb7a1db60d1"), "Florence", new Guid("759ddf47-ae2c-4c21-9351-96e1a535ee77") },
                    { new Guid("c18916b8-06ba-4bc2-b840-7eba08ee04c4"), "Aarhus", new Guid("cca16ece-7f88-4143-9880-2273979b9b43") },
                    { new Guid("c48f2aa2-c52a-4841-9e20-b36ea16f4aab"), "Oslo", new Guid("aa81fa10-b6bd-424d-a5e7-91ad930f489c") },
                    { new Guid("c8cf3bcd-89e9-4298-aec8-de0f25f8c169"), "Bergen", new Guid("aa81fa10-b6bd-424d-a5e7-91ad930f489c") },
                    { new Guid("d2f954bb-403e-453f-8623-89099d3a3e14"), "Odense ", new Guid("cca16ece-7f88-4143-9880-2273979b9b43") }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "FirstName", "LastName", "Phone", "SSN" },
                values: new object[,]
                {
                    { new Guid("155814ba-1fc5-4aa6-af2b-2f815be549df"), new Guid("70538a38-a1e6-4af3-bba6-e628f381e237"), "Antonio", "Pereira", "00351786533", "801009" },
                    { new Guid("401fae0a-27bd-4dae-8482-fd441aa70dde"), new Guid("ab542424-4120-4301-a962-a089f7807d05"), "Manuel", "Carvalho", "00351786533", "851209" },
                    { new Guid("91cf5cb2-1112-44c4-bf62-1393e109fd66"), new Guid("279df6bf-ba3e-4a5b-b1b3-3d6b1ffb7256"), "Elisabeth", "Garnier", "00331786533", "750912" },
                    { new Guid("94b89a4e-8265-450c-9bf8-11181df7f7ac"), new Guid("c48f2aa2-c52a-4841-9e20-b36ea16f4aab"), "Maja", "Nilsen", "0047786533", "861211" },
                    { new Guid("ab560690-c8cf-4348-b27f-947612a3fa74"), new Guid("c8cf3bcd-89e9-4298-aec8-de0f25f8c169"), "Petter", "Bjorge", "00471786533", "820413" },
                    { new Guid("c98b0627-1a25-49bc-b172-a82869faa809"), new Guid("216494e4-bf95-4dda-b21e-3014c4746f6b"), "Elise", "Jensen", "00451786533", "700511" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("035145ec-3d05-4a92-ab28-46dc9e2d42b7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("04c19d62-fad7-4671-8078-c9cbee3befa3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6bfd3991-eb10-45ef-b75c-9d845e69f7e8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7e18f369-3a77-409a-96b1-df200f459fc0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a3ef5e79-81f9-429d-83e5-548a9da68d2a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b1ec0ce6-cf92-4833-b42f-0822236de1d8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("bc2d4d79-8078-49e8-9b1e-5bb7a1db60d1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c18916b8-06ba-4bc2-b840-7eba08ee04c4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d2f954bb-403e-453f-8623-89099d3a3e14"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("09406fcd-8e27-4b22-b56b-3e847425c19c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("0eebf3d9-8f63-445f-8bf1-b787bd1a845d"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("66da974c-1034-41c3-b171-a3123e8afacf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("c5077cff-374a-41de-85c9-a518ae0cd831"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("c960d0cc-cee7-4f2e-8b37-214eebf3159b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("e1dcbc18-faef-4dd5-9a49-aa24a4902c1d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("155814ba-1fc5-4aa6-af2b-2f815be549df"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("401fae0a-27bd-4dae-8482-fd441aa70dde"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("91cf5cb2-1112-44c4-bf62-1393e109fd66"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("94b89a4e-8265-450c-9bf8-11181df7f7ac"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("ab560690-c8cf-4348-b27f-947612a3fa74"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("c98b0627-1a25-49bc-b172-a82869faa809"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("216494e4-bf95-4dda-b21e-3014c4746f6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("279df6bf-ba3e-4a5b-b1b3-3d6b1ffb7256"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("70538a38-a1e6-4af3-bba6-e628f381e237"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ab542424-4120-4301-a962-a089f7807d05"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c48f2aa2-c52a-4841-9e20-b36ea16f4aab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c8cf3bcd-89e9-4298-aec8-de0f25f8c169"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("759ddf47-ae2c-4c21-9351-96e1a535ee77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f5dc1f0-f5b9-4f90-b799-988cb233b1ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7245bba1-58c3-4937-883a-7786bf9f9436"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa81fa10-b6bd-424d-a5e7-91ad930f489c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cca16ece-7f88-4143-9880-2273979b9b43"));

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
    }
}

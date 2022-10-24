using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class people_languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("06904fc4-0af8-414c-a4c6-7ea399796d18"), "Portugal" },
                    { new Guid("19151fc4-66d6-43f1-a4dd-7f4e621a25bd"), "Italy" },
                    { new Guid("53df159b-0340-41bd-a6c1-08932850d180"), "France" },
                    { new Guid("72add6b5-4736-4305-9942-67d80c37fe3b"), "Denmark" },
                    { new Guid("c5dcb563-8019-4ae2-8df4-9adba26a0b71"), "Norway" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), "English" },
                    { new Guid("60ba5dbc-91ba-47f8-b049-dffef8d950f2"), "Swedish" },
                    { new Guid("81379b8f-0663-4e12-9a0e-1ba2a7677d32"), "Italian" },
                    { new Guid("8eb79ef6-9e40-4eef-815f-c1ade9b75ba8"), "French" },
                    { new Guid("acb8694c-4a1e-4245-aa05-72c08c80e594"), "Japanese" },
                    { new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"), "Portuguese" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId" },
                values: new object[,]
                {
                    { new Guid("00a14419-8b6c-4efc-b613-dff0ed24ffc0"), "Florence", new Guid("19151fc4-66d6-43f1-a4dd-7f4e621a25bd") },
                    { new Guid("12c21046-fc43-4079-a6b2-96cc86d110b8"), "Trondheim", new Guid("c5dcb563-8019-4ae2-8df4-9adba26a0b71") },
                    { new Guid("1c7f3184-7bb7-4fed-912b-9594ebd5447e"), "Odense ", new Guid("72add6b5-4736-4305-9942-67d80c37fe3b") },
                    { new Guid("2226a03b-0631-4d88-b75c-f78764a07905"), "Annecy", new Guid("53df159b-0340-41bd-a6c1-08932850d180") },
                    { new Guid("5830a1ed-6e86-422a-96c6-58bf7bdad159"), "Oslo", new Guid("c5dcb563-8019-4ae2-8df4-9adba26a0b71") },
                    { new Guid("5c74cf57-0db6-4a5c-a14e-c8103e1e17be"), "Venice", new Guid("19151fc4-66d6-43f1-a4dd-7f4e621a25bd") },
                    { new Guid("77ff1dc4-64ac-4cea-a318-c33c28bfe2ff"), "Copenhagen", new Guid("72add6b5-4736-4305-9942-67d80c37fe3b") },
                    { new Guid("8df200c6-eb46-4e38-9625-65d955012934"), "Rome", new Guid("19151fc4-66d6-43f1-a4dd-7f4e621a25bd") },
                    { new Guid("b2c77e51-6625-4e68-a51b-5daf4341bf9d"), "Guimaraes", new Guid("06904fc4-0af8-414c-a4c6-7ea399796d18") },
                    { new Guid("b9e0625b-48df-4cc9-9bdf-cdf038680f22"), "Paris", new Guid("53df159b-0340-41bd-a6c1-08932850d180") },
                    { new Guid("d3712e13-eba6-4a22-a7bd-7a884893fb90"), "Dijon", new Guid("53df159b-0340-41bd-a6c1-08932850d180") },
                    { new Guid("d38cf42b-998f-4606-b242-1241d8469019"), "Aarhus", new Guid("72add6b5-4736-4305-9942-67d80c37fe3b") },
                    { new Guid("d5f639bf-01d0-4e4d-8aa3-1948a459bc20"), "Porto", new Guid("06904fc4-0af8-414c-a4c6-7ea399796d18") },
                    { new Guid("e5e93541-9afc-49d6-9f5c-d9ac1f2356c2"), "Braga", new Guid("06904fc4-0af8-414c-a4c6-7ea399796d18") },
                    { new Guid("fc4f5eac-6ece-461c-9928-21484aa5a86c"), "Bergen", new Guid("c5dcb563-8019-4ae2-8df4-9adba26a0b71") }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "FirstName", "LastName", "Phone", "SSN" },
                values: new object[,]
                {
                    { new Guid("088394bb-1b55-402f-99b8-b2b37587b11e"), new Guid("b9e0625b-48df-4cc9-9bdf-cdf038680f22"), "Elisabeth", "Garnier", "00331786533", "750912" },
                    { new Guid("4004a4d0-3c70-4564-b538-4d61abcbd802"), new Guid("e5e93541-9afc-49d6-9f5c-d9ac1f2356c2"), "Manuel", "Carvalho", "00351786533", "851209" },
                    { new Guid("4391eaf7-872b-4473-952a-a059c70327aa"), new Guid("d5f639bf-01d0-4e4d-8aa3-1948a459bc20"), "Antonio", "Pereira", "00351786533", "801009" },
                    { new Guid("a44e066c-449a-4b39-8203-15d683e99722"), new Guid("fc4f5eac-6ece-461c-9928-21484aa5a86c"), "Petter", "Bjorge", "00471786533", "820413" },
                    { new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8"), new Guid("77ff1dc4-64ac-4cea-a318-c33c28bfe2ff"), "Elise", "Jensen", "00451786533", "700511" },
                    { new Guid("ea8f0587-d8b6-4b0b-9d5f-dbab879bb1ec"), new Guid("5830a1ed-6e86-422a-96c6-58bf7bdad159"), "Maja", "Nilsen", "0047786533", "861211" }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("4391eaf7-872b-4473-952a-a059c70327aa") },
                    { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("a44e066c-449a-4b39-8203-15d683e99722") },
                    { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("ea8f0587-d8b6-4b0b-9d5f-dbab879bb1ec") },
                    { new Guid("60ba5dbc-91ba-47f8-b049-dffef8d950f2"), new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8") },
                    { new Guid("8eb79ef6-9e40-4eef-815f-c1ade9b75ba8"), new Guid("088394bb-1b55-402f-99b8-b2b37587b11e") },
                    { new Guid("acb8694c-4a1e-4245-aa05-72c08c80e594"), new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8") },
                    { new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"), new Guid("4004a4d0-3c70-4564-b538-4d61abcbd802") },
                    { new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"), new Guid("4391eaf7-872b-4473-952a-a059c70327aa") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00a14419-8b6c-4efc-b613-dff0ed24ffc0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("12c21046-fc43-4079-a6b2-96cc86d110b8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1c7f3184-7bb7-4fed-912b-9594ebd5447e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2226a03b-0631-4d88-b75c-f78764a07905"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5c74cf57-0db6-4a5c-a14e-c8103e1e17be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8df200c6-eb46-4e38-9625-65d955012934"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b2c77e51-6625-4e68-a51b-5daf4341bf9d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d3712e13-eba6-4a22-a7bd-7a884893fb90"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d38cf42b-998f-4606-b242-1241d8469019"));

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("4391eaf7-872b-4473-952a-a059c70327aa") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("a44e066c-449a-4b39-8203-15d683e99722") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"), new Guid("ea8f0587-d8b6-4b0b-9d5f-dbab879bb1ec") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("60ba5dbc-91ba-47f8-b049-dffef8d950f2"), new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("8eb79ef6-9e40-4eef-815f-c1ade9b75ba8"), new Guid("088394bb-1b55-402f-99b8-b2b37587b11e") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("acb8694c-4a1e-4245-aa05-72c08c80e594"), new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"), new Guid("4004a4d0-3c70-4564-b538-4d61abcbd802") });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"), new Guid("4391eaf7-872b-4473-952a-a059c70327aa") });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("81379b8f-0663-4e12-9a0e-1ba2a7677d32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19151fc4-66d6-43f1-a4dd-7f4e621a25bd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("002dd5e2-73f3-4a29-b20d-2c157a314c95"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("60ba5dbc-91ba-47f8-b049-dffef8d950f2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("8eb79ef6-9e40-4eef-815f-c1ade9b75ba8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("acb8694c-4a1e-4245-aa05-72c08c80e594"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("b62276b9-7d80-4cac-8a25-0b88740467b2"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("088394bb-1b55-402f-99b8-b2b37587b11e"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("4004a4d0-3c70-4564-b538-4d61abcbd802"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("4391eaf7-872b-4473-952a-a059c70327aa"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a44e066c-449a-4b39-8203-15d683e99722"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b9e780fb-adad-48d4-807c-0074d4d88ff8"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("ea8f0587-d8b6-4b0b-9d5f-dbab879bb1ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5830a1ed-6e86-422a-96c6-58bf7bdad159"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77ff1dc4-64ac-4cea-a318-c33c28bfe2ff"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b9e0625b-48df-4cc9-9bdf-cdf038680f22"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d5f639bf-01d0-4e4d-8aa3-1948a459bc20"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e5e93541-9afc-49d6-9f5c-d9ac1f2356c2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fc4f5eac-6ece-461c-9928-21484aa5a86c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06904fc4-0af8-414c-a4c6-7ea399796d18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53df159b-0340-41bd-a6c1-08932850d180"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72add6b5-4736-4305-9942-67d80c37fe3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5dcb563-8019-4ae2-8df4-9adba26a0b71"));

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
    }
}

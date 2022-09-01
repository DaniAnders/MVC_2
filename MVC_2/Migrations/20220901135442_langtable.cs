using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class langtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.InsertData(
                table: "LanguagePerson_",
                columns: new[] { "LanguagesId", "PeopleID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 5 },
                    { 1, 6 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 5, 1 },
                    { 5, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson_",
                keyColumns: new[] { "LanguagesId", "PeopleID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_CityId",
                table: "Person",
                column: "CityId");
        }
    }
}

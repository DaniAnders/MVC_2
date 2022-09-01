using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePerson_",
                columns: table => new
                {
                    LanguagesID = table.Column<int>(type: "int", nullable: false),
                    PeopleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson_", x => new { x.LanguagesID, x.PeopleID });
                    table.ForeignKey(
                        name: "FK_LanguagePerson__Languages_LanguagesID",
                        column: x => x.LanguagesID,
                        principalTable: "Languages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagePerson__People_PeopleID",
                        column: x => x.PeopleID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson__PeopleID",
                table: "LanguagePerson_",
                column: "PeopleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguagePerson_");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}

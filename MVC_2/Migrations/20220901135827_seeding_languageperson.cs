using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class seeding_languageperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[] { 6, "Tupi" });
        }
    }
}

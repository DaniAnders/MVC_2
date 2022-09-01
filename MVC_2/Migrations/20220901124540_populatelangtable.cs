using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_2.Migrations
{
    public partial class populatelangtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguagePerson__Languages_LanguagesID",
                table: "LanguagePerson_");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LanguagesID",
                table: "LanguagePerson_",
                newName: "LanguagesId");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "LanguageName" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "French" },
                    { 3, "Portuguese" },
                    { 4, "Spanish" },
                    { 5, "Swedish" },
                    { 6, "Tupi" }

                });

            migrationBuilder.AddForeignKey(
                name: "FK_LanguagePerson__Languages_LanguagesId",
                table: "LanguagePerson_",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguagePerson__Languages_LanguagesId",
                table: "LanguagePerson_");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LanguagesId",
                table: "LanguagePerson_",
                newName: "LanguagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_LanguagePerson__Languages_LanguagesID",
                table: "LanguagePerson_",
                column: "LanguagesID",
                principalTable: "Languages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstClounProj.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    languageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(nullable: true),
                    languageDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.languageId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookTitle = table.Column<string>(nullable: true),
                    bookAuthor = table.Column<string>(nullable: true),
                    bookDescription = table.Column<string>(nullable: true),
                    bookCategory = table.Column<string>(nullable: true),
                    bookTotalPages = table.Column<int>(nullable: false),
                    bookLanguageId = table.Column<int>(nullable: false),
                    createdDate = table.Column<DateTime>(nullable: true),
                    updateDate = table.Column<DateTime>(nullable: true),
                    LanguageslanguageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_Books_Languages_LanguageslanguageId",
                        column: x => x.LanguageslanguageId,
                        principalTable: "Languages",
                        principalColumn: "languageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageslanguageId",
                table: "Books",
                column: "LanguageslanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}

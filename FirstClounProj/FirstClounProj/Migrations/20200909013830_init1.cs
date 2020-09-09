using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstClounProj.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    bookLanguage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class renameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog2s",
                schema: "domyslna_nazwa_schematu");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Authors",
                newName: "AuthorsID");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "domyslna_nazwa_schematu",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorNameAuthorsID = table.Column<int>(type: "int", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    bookName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BooksId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorNameAuthorsID",
                        column: x => x.AuthorNameAuthorsID,
                        principalSchema: "domyslna_nazwa_schematu",
                        principalTable: "Authors",
                        principalColumn: "AuthorsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                column: "AuthorNameAuthorsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "domyslna_nazwa_schematu");

            migrationBuilder.RenameColumn(
                name: "AuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Authors",
                newName: "AuthorID");

            migrationBuilder.CreateTable(
                name: "Blog2s",
                schema: "domyslna_nazwa_schematu",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog2s", x => x.BlogId);
                });
        }
    }
}

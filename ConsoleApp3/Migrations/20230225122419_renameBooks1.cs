using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class renameBooks1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BooksId",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                newName: "BooksID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BooksID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                newName: "BooksId");
        }
    }
}

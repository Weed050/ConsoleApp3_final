using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class fixBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                column: "AuthorNameAuthorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorNameAuthorsID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                column: "AuthorNameAuthorsID",
                principalSchema: "domyslna_nazwa_schematu",
                principalTable: "Authors",
                principalColumn: "AuthorsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

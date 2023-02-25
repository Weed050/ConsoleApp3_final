using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class addRelationAuthorBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Books",
                column: "AuthorID",
                principalSchema: "domyslna_nazwa_schematu",
                principalTable: "Authors",
                principalColumn: "AuthorsID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Books");
        }
    }
}

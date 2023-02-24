using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class addingTableBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s",
                newName: "bookName");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s");

            migrationBuilder.RenameColumn(
                name: "bookName",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s",
                newName: "Name");
        }
    }
}

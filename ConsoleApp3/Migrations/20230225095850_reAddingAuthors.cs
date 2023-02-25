using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class reAddingAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorName",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s",
                newName: "AuthorID");

            migrationBuilder.CreateTable(
                name: "Authors",
                schema: "domyslna_nazwa_schematu",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors",
                schema: "domyslna_nazwa_schematu");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                schema: "domyslna_nazwa_schematu",
                table: "Blog2s",
                newName: "AuthorName");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Deneme.Migrations
{
    /// <inheritdoc />
    public partial class headerkomplesilindi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Header");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Header",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FifthLink = table.Column<string>(type: "TEXT", nullable: false),
                    FifthName = table.Column<string>(type: "TEXT", nullable: false),
                    FirstLink = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    FourthLink = table.Column<string>(type: "TEXT", nullable: false),
                    FourthName = table.Column<string>(type: "TEXT", nullable: false),
                    SecondLink = table.Column<string>(type: "TEXT", nullable: false),
                    SecondName = table.Column<string>(type: "TEXT", nullable: false),
                    ThirdLink = table.Column<string>(type: "TEXT", nullable: false),
                    ThirdName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Header", x => x.Id);
                });
        }
    }
}

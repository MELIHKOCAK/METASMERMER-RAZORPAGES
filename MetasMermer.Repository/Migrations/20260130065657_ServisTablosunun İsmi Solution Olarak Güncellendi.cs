using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetasMermer.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ServisTablosununİsmiSolutionOlarakGüncellendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.CreateTable(
                name: "Solution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solution", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Solution",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, " Metaş mermer ve granit sanayii olarak her türlü • Mutfak Tezgahı • Denizlik • Basamak • Mezar işleriniz itina ile yapılır.", "Hizmetlerimiz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solution");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, " Metaş mermer ve granit sanayii olarak her türlü • Mutfak Tezgahı • Denizlik • Basamak • Mezar işleriniz itina ile yapılır.", "Hizmetlerimiz" });
        }
    }
}

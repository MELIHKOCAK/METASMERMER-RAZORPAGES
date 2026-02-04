using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetasMermer.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class aboutEntitysindekiImageLinkAlaniDeğiştirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageLink",
                value: "[\"/img/hero.webp\",\"/img/kursat.webp\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageLink",
                value: "[\"/img/hero.webp\"]");
        }
    }
}

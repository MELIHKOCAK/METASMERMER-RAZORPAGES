using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Deneme.Migrations
{
    /// <inheritdoc />
    public partial class headernameeklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FifthName",
                table: "Header",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Header",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FourthName",
                table: "Header",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Header",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdName",
                table: "Header",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifthName",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "FourthName",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "ThirdName",
                table: "Header");
        }
    }
}

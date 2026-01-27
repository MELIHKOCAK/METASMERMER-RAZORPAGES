using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MetasMermer.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Footer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstagramLink = table.Column<string>(type: "TEXT", nullable: false),
                    FacebookLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Whatsapp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whatsapp", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Description", "ImageLink", "Title" },
                values: new object[] { 1, "2007 Yılında Tokat'ın Niksar ilçesinde sanayi bölgesinde kurulan \"Metaş Mermer Ve Granit Sanayii kalitesini\" geliştirerek siz değerli müşterilerimize hizmet vermeye devam etmektedir..", "/img/hero.webp", "Her Zaman Kalite" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "905325887656" },
                    { 2, "905374480024" },
                    { 3, "kursatersin@icloud.com" },
                    { 4, "https://www.google.com/maps?ll=40.583868,36.919473&z=16&t=m&hl=tr&gl=TR&mapclient=embed&cid=13389469205681263836" },
                    { 5, "Sanayi Sitesi 9.Blok No: 50 Niksar/Tokat" },
                    { 6, "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3030.0853262311134!2d36.91728441569593!3d40.58387195338053!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x407d1b6512db2dab%3A0xb9d0f34d57a9d4dc!2sMETA%C5%9E%20MERMER!5e0!3m2!1str!2str!4v1665173589058!5m2!1str!2str" }
                });

            migrationBuilder.InsertData(
                table: "Footer",
                columns: new[] { "Id", "FacebookLink", "InstagramLink" },
                values: new object[] { 1, "https://www.facebook.com/metas.muratersin", "https://www.instagram.com/metasmuratersin" });

            migrationBuilder.InsertData(
                table: "Hero",
                columns: new[] { "Id", "CompanyName" },
                values: new object[] { 1, "Metaş Mermere" });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, " Metaş mermer ve granit sanayii olarak her türlü • Mutfak Tezgahı • Denizlik • Basamak • Mezar işleriniz itina ile yapılır.", "Hizmetlerimiz" });

            migrationBuilder.InsertData(
                table: "Whatsapp",
                columns: new[] { "Id", "Description", "PhoneNumber", "Title" },
                values: new object[] { 1, "Merhaba! 👋 Daha Fazla Bilgi İçin Bizlere Whatsapdan Ulaşabilirsiniz", "905374480024", "Size Nasıl Yardımcı Olabilirim?" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Footer");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "Hero");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Whatsapp");
        }
    }
}

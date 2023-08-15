using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthorizeVeAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class kullanici1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "id", "ad", "email", "role", "sifre", "soyad" },
                values: new object[,]
                {
                    { 1, "Kullanıcı1", "kullanici1@gmail.com", "Yönetici", "kullanici1", "Kullanıcı1" },
                    { 2, "Kullanıcı2", "kullanici2@gmail.com", "Admin", "kullanici2", "Kullanıcı2" },
                    { 3, "Kullanıcı3", "kullanici3@gmail.com", "Üye", "kullanici3", "Kullanıcı3" },
                    { 4, "Kullanıcı4", "kullanici4@gmail.com", "Ban", "kullanici4", "Kullanıcı4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}

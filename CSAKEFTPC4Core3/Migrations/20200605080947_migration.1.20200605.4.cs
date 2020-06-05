using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration1202006054 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programkods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(nullable: true),
                    Nev = table.Column<string>(nullable: true),
                    Megnevezes = table.Column<string>(nullable: true),
                    Kod = table.Column<string>(nullable: true),
                    PublikusKod = table.Column<string>(nullable: true),
                    Nevter = table.Column<string>(nullable: true),
                    Leiras = table.Column<string>(nullable: true),
                    Serialization = table.Column<string>(nullable: true),
                    Forrasszoveg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programkods", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programkods");
        }
    }
}

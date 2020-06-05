using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration1202006059 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdatElems",
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
                    Adattipus = table.Column<string>(nullable: true),
                    HumanNev = table.Column<string>(nullable: true),
                    BelsoNev = table.Column<string>(nullable: true),
                    Irany = table.Column<string>(nullable: true),
                    Opcionalis = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdatElems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdatElems");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration120200605 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programkods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programkods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forrasszoveg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programkods", x => x.Id);
                });
        }
    }
}

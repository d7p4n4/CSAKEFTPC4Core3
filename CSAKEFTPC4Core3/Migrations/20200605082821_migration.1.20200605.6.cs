using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration1202006056 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tablas",
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
                    Serialization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaOszlop",
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
                    TablaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaOszlop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaOszlop_Tablas_TablaId",
                        column: x => x.TablaId,
                        principalTable: "Tablas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TablaOszlop_TablaId",
                table: "TablaOszlop",
                column: "TablaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaOszlop");

            migrationBuilder.DropTable(
                name: "Tablas");
        }
    }
}

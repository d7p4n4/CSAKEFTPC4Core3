using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration1202006057 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdatElems");

            migrationBuilder.CreateTable(
                name: "Keprnyos",
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
                    RegiKepernyo = table.Column<string>(nullable: true),
                    UjKepernyo = table.Column<string>(nullable: true),
                    GyermekListaKepernyo = table.Column<string>(nullable: true),
                    FoAzonosito = table.Column<string>(nullable: true),
                    KepernyoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keprnyos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keprnyos_Keprnyos_KepernyoId",
                        column: x => x.KepernyoId,
                        principalTable: "Keprnyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ellenorzes",
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
                    Uzenet = table.Column<string>(nullable: true),
                    Feltetel = table.Column<string>(nullable: true),
                    KepernyoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ellenorzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ellenorzes_Keprnyos_KepernyoId",
                        column: x => x.KepernyoId,
                        principalTable: "Keprnyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feladat",
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
                    Tipus = table.Column<string>(nullable: true),
                    Azonosito = table.Column<string>(nullable: true),
                    MegvalositasFolyamatban = table.Column<bool>(nullable: false),
                    MegvalositasKesz = table.Column<bool>(nullable: false),
                    JavitasFolyamatban = table.Column<bool>(nullable: false),
                    JavitasKesz = table.Column<bool>(nullable: false),
                    EllenorzesFolyamatban = table.Column<bool>(nullable: false),
                    Hibatlan = table.Column<bool>(nullable: false),
                    Hibas = table.Column<bool>(nullable: false),
                    KeszultsegiSzazalek = table.Column<int>(nullable: false),
                    Megvalosito = table.Column<string>(nullable: true),
                    Ellenorzo = table.Column<string>(nullable: true),
                    FeladatId = table.Column<int>(nullable: true),
                    KepernyoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feladat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feladat_Feladat_FeladatId",
                        column: x => x.FeladatId,
                        principalTable: "Feladat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feladat_Keprnyos_KepernyoId",
                        column: x => x.KepernyoId,
                        principalTable: "Keprnyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funkcio",
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
                    Szerep = table.Column<string>(nullable: true),
                    Feltetel = table.Column<string>(nullable: true),
                    Utasitas = table.Column<string>(nullable: true),
                    Engedely = table.Column<string>(nullable: true),
                    Billentyu = table.Column<string>(nullable: true),
                    ErintettObjektum = table.Column<string>(nullable: true),
                    KepernyoKapcsolat = table.Column<bool>(nullable: false),
                    OsMetodus = table.Column<bool>(nullable: false),
                    NemHasznalt = table.Column<bool>(nullable: false),
                    EgyediBeepites = table.Column<bool>(nullable: false),
                    FejlecElem = table.Column<bool>(nullable: false),
                    GombsorElem = table.Column<bool>(nullable: false),
                    KepernyoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funkcio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funkcio_Keprnyos_KepernyoId",
                        column: x => x.KepernyoId,
                        principalTable: "Keprnyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Metodus",
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
                    Uzemmod = table.Column<int>(nullable: false),
                    Skalar = table.Column<bool>(nullable: false),
                    Szerep = table.Column<string>(nullable: true),
                    KepernyoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metodus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Metodus_Keprnyos_KepernyoId",
                        column: x => x.KepernyoId,
                        principalTable: "Keprnyos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaroltEljarasArgumentum",
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
                    Opcionalis = table.Column<bool>(nullable: false),
                    MetodusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaroltEljarasArgumentum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaroltEljarasArgumentum_Metodus_MetodusId",
                        column: x => x.MetodusId,
                        principalTable: "Metodus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ellenorzes_KepernyoId",
                table: "Ellenorzes",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_Feladat_FeladatId",
                table: "Feladat",
                column: "FeladatId");

            migrationBuilder.CreateIndex(
                name: "IX_Feladat_KepernyoId",
                table: "Feladat",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funkcio_KepernyoId",
                table: "Funkcio",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_Keprnyos_KepernyoId",
                table: "Keprnyos",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_Metodus_KepernyoId",
                table: "Metodus",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_TaroltEljarasArgumentum_MetodusId",
                table: "TaroltEljarasArgumentum",
                column: "MetodusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ellenorzes");

            migrationBuilder.DropTable(
                name: "Feladat");

            migrationBuilder.DropTable(
                name: "Funkcio");

            migrationBuilder.DropTable(
                name: "TaroltEljarasArgumentum");

            migrationBuilder.DropTable(
                name: "Metodus");

            migrationBuilder.DropTable(
                name: "Keprnyos");

            migrationBuilder.CreateTable(
                name: "AdatElems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adattipus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelsoNev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HumanNev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Irany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opcionalis = table.Column<bool>(type: "bit", nullable: false),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdatElems", x => x.Id);
                });
        }
    }
}

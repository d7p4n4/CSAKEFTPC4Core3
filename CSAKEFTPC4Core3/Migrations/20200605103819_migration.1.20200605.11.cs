using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration12020060511 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_AdatkorId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_FeladatId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Feladat_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Funkcio_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KepernyoId1",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_CelMuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_CelId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_ForrasId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MegfeleltetesCsomopontId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Metodus_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KeresId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_ValaszId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_TablaId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MetodusId",
                table: "RAMetaObjektums");

            migrationBuilder.DropForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_AdatkorId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_FeladatId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_Feladat_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_Funkcio_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_KepernyoId1",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_CelMuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_CelId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_ForrasId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_MegfeleltetesCsomopontId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_Metodus_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_KeresId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_ValaszId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_TablaId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_MetodusId",
                table: "RAMetaObjektums");

            migrationBuilder.DropIndex(
                name: "IX_RAMetaObjektums_TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "AdatkorId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Adattipus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "BelsoNev",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "HumanNev",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Irany",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Opcionalis",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Feltetel",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Uzenet",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Azonosito",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "EllenorzesFolyamatban",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Ellenorzo",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "FeladatId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Hibas",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Hibatlan",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "JavitasFolyamatban",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "JavitasKesz",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Feladat_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "KeszultsegiSzazalek",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "MegvalositasFolyamatban",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "MegvalositasKesz",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Megvalosito",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Tipus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Billentyu",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "EgyediBeepites",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Engedely",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "ErintettObjektum",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "FejlecElem",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Funkcio_Feltetel",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "GombsorElem",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Funkcio_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "KepernyoKapcsolat",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "NemHasznalt",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "OsMetodus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Szerep",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Utasitas",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "FoAzonosito",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "GyermekListaKepernyo",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "KepernyoId1",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "RegiKepernyo",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "UjKepernyo",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "CelMuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "CelId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "ForrasId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "MegfeleltetesCsomopontId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Metodus_KepernyoId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Skalar",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Metodus_Szerep",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Uzemmod",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Muvelet_FoAzonosito",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Foazonositos",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "KeresId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Nevproblemas",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TurelmiIdo",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "ValaszId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "ValaszTipus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Forrasszoveg",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TablaOszlop_Adattipus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TablaId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_Adattipus",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_BelsoNev",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_HumanNev",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_Irany",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "MetodusId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_Opcionalis",
                table: "RAMetaObjektums");

            migrationBuilder.CreateTable(
                name: "Programkods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.AddColumn<int>(
                name: "AdatkorId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adattipus",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BelsoNev",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HumanNev",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Irany",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Opcionalis",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Feltetel",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KepernyoId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uzenet",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Azonosito",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EllenorzesFolyamatban",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ellenorzo",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeladatId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Hibas",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Hibatlan",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "JavitasFolyamatban",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "JavitasKesz",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Feladat_KepernyoId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeszultsegiSzazalek",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MegvalositasFolyamatban",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MegvalositasKesz",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Megvalosito",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipus",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billentyu",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EgyediBeepites",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Engedely",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErintettObjektum",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FejlecElem",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Funkcio_Feltetel",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GombsorElem",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Funkcio_KepernyoId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KepernyoKapcsolat",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NemHasznalt",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OsMetodus",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Szerep",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Utasitas",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoAzonosito",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GyermekListaKepernyo",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KepernyoId1",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegiKepernyo",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UjKepernyo",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CelMuveletId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CelId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForrasId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MegfeleltetesCsomopontId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Metodus_KepernyoId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Skalar",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metodus_Szerep",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Uzemmod",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Muvelet_FoAzonosito",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Foazonositos",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeresId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MuveletId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Nevproblemas",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurelmiIdo",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValaszId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValaszTipus",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Forrasszoveg",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TablaOszlop_Adattipus",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TablaId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_Adattipus",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_BelsoNev",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_HumanNev",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_Irany",
                table: "RAMetaObjektums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MetodusId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TaroltEljarasArgumentum_Opcionalis",
                table: "RAMetaObjektums",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_AdatkorId",
                table: "RAMetaObjektums",
                column: "AdatkorId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_KepernyoId",
                table: "RAMetaObjektums",
                column: "KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_FeladatId",
                table: "RAMetaObjektums",
                column: "FeladatId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_Feladat_KepernyoId",
                table: "RAMetaObjektums",
                column: "Feladat_KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_Funkcio_KepernyoId",
                table: "RAMetaObjektums",
                column: "Funkcio_KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_KepernyoId1",
                table: "RAMetaObjektums",
                column: "KepernyoId1");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_CelMuveletId",
                table: "RAMetaObjektums",
                column: "CelMuveletId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_CelId",
                table: "RAMetaObjektums",
                column: "CelId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_ForrasId",
                table: "RAMetaObjektums",
                column: "ForrasId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_MegfeleltetesCsomopontId",
                table: "RAMetaObjektums",
                column: "MegfeleltetesCsomopontId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_Metodus_KepernyoId",
                table: "RAMetaObjektums",
                column: "Metodus_KepernyoId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_KeresId",
                table: "RAMetaObjektums",
                column: "KeresId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_MuveletId",
                table: "RAMetaObjektums",
                column: "MuveletId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_ValaszId",
                table: "RAMetaObjektums",
                column: "ValaszId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_TablaId",
                table: "RAMetaObjektums",
                column: "TablaId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_MetodusId",
                table: "RAMetaObjektums",
                column: "MetodusId");

            migrationBuilder.CreateIndex(
                name: "IX_RAMetaObjektums_TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums",
                column: "TaroltEljarasArgumentum_MuveletId");

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_AdatkorId",
                table: "RAMetaObjektums",
                column: "AdatkorId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KepernyoId",
                table: "RAMetaObjektums",
                column: "KepernyoId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_FeladatId",
                table: "RAMetaObjektums",
                column: "FeladatId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Feladat_KepernyoId",
                table: "RAMetaObjektums",
                column: "Feladat_KepernyoId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Funkcio_KepernyoId",
                table: "RAMetaObjektums",
                column: "Funkcio_KepernyoId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KepernyoId1",
                table: "RAMetaObjektums",
                column: "KepernyoId1",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_CelMuveletId",
                table: "RAMetaObjektums",
                column: "CelMuveletId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_CelId",
                table: "RAMetaObjektums",
                column: "CelId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_ForrasId",
                table: "RAMetaObjektums",
                column: "ForrasId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MegfeleltetesCsomopontId",
                table: "RAMetaObjektums",
                column: "MegfeleltetesCsomopontId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_Metodus_KepernyoId",
                table: "RAMetaObjektums",
                column: "Metodus_KepernyoId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_KeresId",
                table: "RAMetaObjektums",
                column: "KeresId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MuveletId",
                table: "RAMetaObjektums",
                column: "MuveletId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_ValaszId",
                table: "RAMetaObjektums",
                column: "ValaszId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_TablaId",
                table: "RAMetaObjektums",
                column: "TablaId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_MetodusId",
                table: "RAMetaObjektums",
                column: "MetodusId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RAMetaObjektums_RAMetaObjektums_TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums",
                column: "TaroltEljarasArgumentum_MuveletId",
                principalTable: "RAMetaObjektums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

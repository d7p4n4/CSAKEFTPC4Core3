using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration12020060510 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaroltEljarasArgumentum_Metodus_MetodusId",
                table: "TaroltEljarasArgumentum");

            migrationBuilder.DropTable(
                name: "AdatElems");

            migrationBuilder.DropTable(
                name: "Ellenorzes");

            migrationBuilder.DropTable(
                name: "Feladat");

            migrationBuilder.DropTable(
                name: "Funkcio");

            migrationBuilder.DropTable(
                name: "Metodus");

            migrationBuilder.DropTable(
                name: "Programkods");

            migrationBuilder.DropTable(
                name: "TablaOszlop");

            migrationBuilder.DropTable(
                name: "Keprnyos");

            migrationBuilder.DropTable(
                name: "Tablas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaroltEljarasArgumentum",
                table: "TaroltEljarasArgumentum");

            migrationBuilder.RenameTable(
                name: "TaroltEljarasArgumentum",
                newName: "RAMetaObjektums");

            migrationBuilder.RenameIndex(
                name: "IX_TaroltEljarasArgumentum_MetodusId",
                table: "RAMetaObjektums",
                newName: "IX_RAMetaObjektums_MetodusId");

            migrationBuilder.AlterColumn<bool>(
                name: "Opcionalis",
                table: "RAMetaObjektums",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "AdatkorId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Feltetel",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KepernyoId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uzenet",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Azonosito",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EllenorzesFolyamatban",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ellenorzo",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeladatId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Hibas",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Hibatlan",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "JavitasFolyamatban",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "JavitasKesz",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Feladat_KepernyoId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeszultsegiSzazalek",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MegvalositasFolyamatban",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MegvalositasKesz",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Megvalosito",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipus",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Billentyu",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EgyediBeepites",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Engedely",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErintettObjektum",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FejlecElem",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Funkcio_Feltetel",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GombsorElem",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Funkcio_KepernyoId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KepernyoKapcsolat",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NemHasznalt",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OsMetodus",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Szerep",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Utasitas",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoAzonosito",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GyermekListaKepernyo",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KepernyoId1",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegiKepernyo",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UjKepernyo",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CelMuveletId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CelId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForrasId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MegfeleltetesCsomopontId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Metodus_KepernyoId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Skalar",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Metodus_Szerep",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Uzemmod",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Muvelet_FoAzonosito",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Foazonositos",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeresId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MuveletId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Nevproblemas",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurelmiIdo",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValaszId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ValaszTipus",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Forrasszoveg",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "RAMetaObjektums",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TablaOszlop_Adattipus",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TablaId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_Adattipus",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_BelsoNev",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_HumanNev",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaroltEljarasArgumentum_Irany",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TaroltEljarasArgumentum_Opcionalis",
                table: "RAMetaObjektums",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RAMetaObjektums",
                table: "RAMetaObjektums",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_RAMetaObjektums",
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
                name: "IX_RAMetaObjektums_TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "AdatkorId",
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
                name: "TaroltEljarasArgumentum_MuveletId",
                table: "RAMetaObjektums");

            migrationBuilder.DropColumn(
                name: "TaroltEljarasArgumentum_Opcionalis",
                table: "RAMetaObjektums");

            migrationBuilder.RenameTable(
                name: "RAMetaObjektums",
                newName: "TaroltEljarasArgumentum");

            migrationBuilder.RenameIndex(
                name: "IX_RAMetaObjektums_MetodusId",
                table: "TaroltEljarasArgumentum",
                newName: "IX_TaroltEljarasArgumentum_MetodusId");

            migrationBuilder.AlterColumn<bool>(
                name: "Opcionalis",
                table: "TaroltEljarasArgumentum",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaroltEljarasArgumentum",
                table: "TaroltEljarasArgumentum",
                column: "Id");

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

            migrationBuilder.CreateTable(
                name: "Keprnyos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoAzonosito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GyermekListaKepernyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KepernyoId = table.Column<int>(type: "int", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegiKepernyo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UjKepernyo = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Tablas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Tablas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ellenorzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feltetel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KepernyoId = table.Column<int>(type: "int", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uzenet = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Azonosito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EllenorzesFolyamatban = table.Column<bool>(type: "bit", nullable: false),
                    Ellenorzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeladatId = table.Column<int>(type: "int", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hibas = table.Column<bool>(type: "bit", nullable: false),
                    Hibatlan = table.Column<bool>(type: "bit", nullable: false),
                    JavitasFolyamatban = table.Column<bool>(type: "bit", nullable: false),
                    JavitasKesz = table.Column<bool>(type: "bit", nullable: false),
                    KepernyoId = table.Column<int>(type: "int", nullable: true),
                    KeszultsegiSzazalek = table.Column<int>(type: "int", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MegvalositasFolyamatban = table.Column<bool>(type: "bit", nullable: false),
                    MegvalositasKesz = table.Column<bool>(type: "bit", nullable: false),
                    Megvalosito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Billentyu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgyediBeepites = table.Column<bool>(type: "bit", nullable: false),
                    Engedely = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErintettObjektum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FejlecElem = table.Column<bool>(type: "bit", nullable: false),
                    Feltetel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GombsorElem = table.Column<bool>(type: "bit", nullable: false),
                    KepernyoId = table.Column<int>(type: "int", nullable: true),
                    KepernyoKapcsolat = table.Column<bool>(type: "bit", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NemHasznalt = table.Column<bool>(type: "bit", nullable: false),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OsMetodus = table.Column<bool>(type: "bit", nullable: false),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Szerep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Utasitas = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KepernyoId = table.Column<int>(type: "int", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skalar = table.Column<bool>(type: "bit", nullable: false),
                    Szerep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uzemmod = table.Column<int>(type: "int", nullable: false)
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
                name: "TablaOszlop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adattipus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nevter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublikusKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TablaId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_TablaOszlop_TablaId",
                table: "TablaOszlop",
                column: "TablaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaroltEljarasArgumentum_Metodus_MetodusId",
                table: "TaroltEljarasArgumentum",
                column: "MetodusId",
                principalTable: "Metodus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

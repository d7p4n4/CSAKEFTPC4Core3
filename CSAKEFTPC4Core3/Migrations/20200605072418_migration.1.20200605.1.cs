using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSAKEFTPC4Core3.Migrations
{
    public partial class migration1202006051 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ac4yPersistentChilds");

            migrationBuilder.DropTable(
                name: "Ac4yIdentificationBase");
        }
    }
}

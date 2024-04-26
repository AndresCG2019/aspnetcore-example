using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class RelacionesNewEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewEntity_SimpleEntity_OpcionId",
                table: "NewEntity");

            migrationBuilder.RenameColumn(
                name: "OpcionId",
                table: "NewEntity",
                newName: "IdOpcion");

            migrationBuilder.RenameIndex(
                name: "IX_NewEntity_OpcionId",
                table: "NewEntity",
                newName: "IX_NewEntity_IdOpcion");

            migrationBuilder.AddForeignKey(
                name: "FK_NewEntity_SimpleEntity_IdOpcion",
                table: "NewEntity",
                column: "IdOpcion",
                principalTable: "SimpleEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewEntity_SimpleEntity_IdOpcion",
                table: "NewEntity");

            migrationBuilder.RenameColumn(
                name: "IdOpcion",
                table: "NewEntity",
                newName: "OpcionId");

            migrationBuilder.RenameIndex(
                name: "IX_NewEntity_IdOpcion",
                table: "NewEntity",
                newName: "IX_NewEntity_OpcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewEntity_SimpleEntity_OpcionId",
                table: "NewEntity",
                column: "OpcionId",
                principalTable: "SimpleEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

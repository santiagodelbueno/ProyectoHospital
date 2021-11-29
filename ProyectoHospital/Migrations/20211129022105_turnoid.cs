using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoHospital.Migrations
{
    public partial class turnoid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Turno_turnId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_turnId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "turnId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "TurnoId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TurnoId",
                table: "Usuario",
                column: "TurnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Turno_TurnoId",
                table: "Usuario",
                column: "TurnoId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Turno_TurnoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_TurnoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "TurnoId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "turnId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_turnId",
                table: "Usuario",
                column: "turnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Turno_turnId",
                table: "Usuario",
                column: "turnId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

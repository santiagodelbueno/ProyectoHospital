using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoHospital.Migrations
{
    public partial class Hospital1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Turno_numeroId",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Medico_numeroId",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "numeroId",
                table: "Medico");

            migrationBuilder.AddColumn<int>(
                name: "idMedico",
                table: "Turno",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idMedico",
                table: "Turno");

            migrationBuilder.AddColumn<int>(
                name: "numeroId",
                table: "Medico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_numeroId",
                table: "Medico",
                column: "numeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Turno_numeroId",
                table: "Medico",
                column: "numeroId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

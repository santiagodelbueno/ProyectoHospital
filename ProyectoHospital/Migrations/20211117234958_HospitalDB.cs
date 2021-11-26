using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoHospital.Migrations
{
    public partial class HospitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fecha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dia = table.Column<int>(nullable: false),
                    mes = table.Column<int>(nullable: false),
                    año = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fecha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaId = table.Column<int>(nullable: true),
                    hora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turno_Fecha_fechaId",
                        column: x => x.fechaId,
                        principalTable: "Fecha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turno_fechaId",
                table: "Turno",
                column: "fechaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Fecha");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Usuario");
        }
    }
}

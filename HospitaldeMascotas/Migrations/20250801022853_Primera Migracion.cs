using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitaldeMascotas.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Raza = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Edad = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NombrePropietario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CedulaPropietario = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DireccionPropietario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TelefonoPropietario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaRegistro = table.Column<DateOnly>(type: "date", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.IdMascota);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascota");
        }
    }
}

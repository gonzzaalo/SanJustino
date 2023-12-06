using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class ActualizamosProfesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Profesores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Hernandez", "Javier" });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Haup", "Leonardo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Profesores");

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Javier Hernandez");

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Leonardo Haup");
        }
    }
}

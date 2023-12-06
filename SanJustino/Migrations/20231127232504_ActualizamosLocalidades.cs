using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class ActualizamosLocalidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodigoPostal",
                table: "Localidades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CodigoPostal",
                value: "3040");

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CodigoPostal",
                value: "3045");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CodigoPostal",
                table: "Localidades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CodigoPostal",
                value: 3040);

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CodigoPostal",
                value: 3045);
        }
    }
}

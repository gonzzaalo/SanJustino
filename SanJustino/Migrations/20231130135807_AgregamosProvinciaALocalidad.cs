using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosProvinciaALocalidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Localidades",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProvinciaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProvinciaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaId",
                table: "Localidades",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Localidades_Provincias_ProvinciaId",
                table: "Localidades",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Localidades_Provincias_ProvinciaId",
                table: "Localidades");

            migrationBuilder.DropIndex(
                name: "IX_Localidades_ProvinciaId",
                table: "Localidades");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Localidades");
        }
    }
}

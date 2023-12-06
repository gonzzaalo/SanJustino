using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosLocalidadADeportistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Deportistas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocalidadId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocalidadId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Deportistas_LocalidadId",
                table: "Deportistas",
                column: "LocalidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deportistas_Localidades_LocalidadId",
                table: "Deportistas",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deportistas_Localidades_LocalidadId",
                table: "Deportistas");

            migrationBuilder.DropIndex(
                name: "IX_Deportistas_LocalidadId",
                table: "Deportistas");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Deportistas");
        }
    }
}

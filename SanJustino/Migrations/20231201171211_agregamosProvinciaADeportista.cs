using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class agregamosProvinciaADeportista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinciaId",
                table: "Deportistas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProvinciaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProvinciaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Deportistas_ProvinciaId",
                table: "Deportistas",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deportistas_Provincias_ProvinciaId",
                table: "Deportistas",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deportistas_Provincias_ProvinciaId",
                table: "Deportistas");

            migrationBuilder.DropIndex(
                name: "IX_Deportistas_ProvinciaId",
                table: "Deportistas");

            migrationBuilder.DropColumn(
                name: "ProvinciaId",
                table: "Deportistas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosProfesorADeportes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Deportes",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Deportes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfesorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Deportes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfesorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Deportes_ProfesorId",
                table: "Deportes",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deportes_Profesores_ProfesorId",
                table: "Deportes",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deportes_Profesores_ProfesorId",
                table: "Deportes");

            migrationBuilder.DropIndex(
                name: "IX_Deportes_ProfesorId",
                table: "Deportes");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Deportes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoDatosSemillaDeportista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deportistas",
                columns: new[] { "Id", "Apellido", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Reynoso", "Formosa 2110", "gonza@gmail.com", "Gonzalo", "3465088483" },
                    { 2, "Gonzalez", "Formosa 2110", "Mili@gmail.com", "Milagros", "346578345783" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Deportistas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

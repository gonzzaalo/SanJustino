using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanJustino.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosDeporte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horarios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deportes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Deportes",
                columns: new[] { "Id", "Horarios", "Nombre" },
                values: new object[,]
                {
                    { 1, "Lunes a Viernes 21:00 hs", "Futsal" },
                    { 2, "Lunes a Viernes 20:00 hs", "Voley" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deportes");
        }
    }
}

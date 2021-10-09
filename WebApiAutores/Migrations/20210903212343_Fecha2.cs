using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiAutores.Migrations
{
    public partial class Fecha2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaDeCreacion",
                table: "Libros",
                newName: "FechaPublicacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaPublicacion",
                table: "Libros",
                newName: "FechaDeCreacion");
        }
    }
}

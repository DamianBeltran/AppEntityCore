using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class CreacionTablaCategoriasBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) // metodo cuando modificamos 
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) // metodo para cuando eliminamos 
        {
            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

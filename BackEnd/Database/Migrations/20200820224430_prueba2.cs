using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "TareasRealizadas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "TareasRealizadas",
                type: "int",
                nullable: true);
        }
    }
}

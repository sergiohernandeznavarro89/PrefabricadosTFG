using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class prueba3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "TareasRealizadas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "TareasRealizadas");
        }
    }
}

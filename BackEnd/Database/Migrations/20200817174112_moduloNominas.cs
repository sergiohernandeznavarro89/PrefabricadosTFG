using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class moduloNominas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParesRealizados",
                table: "TareasRealizadas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParesRealizados",
                table: "TareasRealizadas");
        }
    }
}

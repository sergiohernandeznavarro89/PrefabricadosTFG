using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class moduloNominasModificacionNominas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Importe",
                table: "Nominas",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Importe",
                table: "Nominas");
        }
    }
}

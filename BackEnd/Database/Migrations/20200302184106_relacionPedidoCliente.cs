using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class relacionPedidoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteIdCliente",
                table: "Pedidos",
                column: "ClienteIdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteIdCliente",
                table: "Pedidos",
                column: "ClienteIdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Pedidos");
        }
    }
}

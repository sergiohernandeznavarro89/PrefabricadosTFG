using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class ErrorRelacionPedidoEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Pedidos_PedidoIdPedido",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PedidoIdPedido",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Empleados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PedidoIdPedido",
                table: "Empleados",
                column: "PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Pedidos_PedidoIdPedido",
                table: "Empleados",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

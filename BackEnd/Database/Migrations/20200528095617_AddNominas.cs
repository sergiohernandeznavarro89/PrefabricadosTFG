using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AddNominas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Trabajos_TrabajoIdTrabajo",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_TrabajoIdTrabajo",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdTrabajo",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "TrabajoIdTrabajo",
                table: "Pedidos");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Nif = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Poblacion = table.Column<string>(nullable: true),
                    Provincia = table.Column<string>(nullable: true),
                    CodPostal = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    IBAN = table.Column<int>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false),
                    PedidoIdPedido = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrabajosPedidos",
                columns: table => new
                {
                    IdTrabajoPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTrabajo = table.Column<int>(nullable: false),
                    TrabajoIdTrabajo = table.Column<int>(nullable: true),
                    IdPedido = table.Column<int>(nullable: false),
                    PedidoIdPedido = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrabajosPedidos", x => x.IdTrabajoPedido);
                    table.ForeignKey(
                        name: "FK_TrabajosPedidos_Pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrabajosPedidos_Trabajos_TrabajoIdTrabajo",
                        column: x => x.TrabajoIdTrabajo,
                        principalTable: "Trabajos",
                        principalColumn: "IdTrabajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nominas",
                columns: table => new
                {
                    IdNomina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<int>(nullable: false),
                    EmpleadoIdEmpleado = table.Column<int>(nullable: true),
                    IdTrabajo = table.Column<int>(nullable: false),
                    TrabajoIdTrabajo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominas", x => x.IdNomina);
                    table.ForeignKey(
                        name: "FK_Nominas_Empleados_EmpleadoIdEmpleado",
                        column: x => x.EmpleadoIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nominas_Trabajos_TrabajoIdTrabajo",
                        column: x => x.TrabajoIdTrabajo,
                        principalTable: "Trabajos",
                        principalColumn: "IdTrabajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TareasRealizadas",
                columns: table => new
                {
                    IdTareaRealizada = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRealizacion = table.Column<DateTime>(nullable: false),
                    HorasDedicadas = table.Column<int>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false),
                    PedidoIdPedido = table.Column<int>(nullable: true),
                    IdEmpleado = table.Column<int>(nullable: false),
                    EmpleadoIdEmpleado = table.Column<int>(nullable: true),
                    IdTrabajo = table.Column<int>(nullable: false),
                    TrabajoIdTrabajo = table.Column<int>(nullable: true),
                    IdNomina = table.Column<int>(nullable: false),
                    NominaIdNomina = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TareasRealizadas", x => x.IdTareaRealizada);
                    table.ForeignKey(
                        name: "FK_TareasRealizadas_Empleados_EmpleadoIdEmpleado",
                        column: x => x.EmpleadoIdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TareasRealizadas_Nominas_NominaIdNomina",
                        column: x => x.NominaIdNomina,
                        principalTable: "Nominas",
                        principalColumn: "IdNomina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TareasRealizadas_Pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TareasRealizadas_Trabajos_TrabajoIdTrabajo",
                        column: x => x.TrabajoIdTrabajo,
                        principalTable: "Trabajos",
                        principalColumn: "IdTrabajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PedidoIdPedido",
                table: "Empleados",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_EmpleadoIdEmpleado",
                table: "Nominas",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Nominas_TrabajoIdTrabajo",
                table: "Nominas",
                column: "TrabajoIdTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_TareasRealizadas_EmpleadoIdEmpleado",
                table: "TareasRealizadas",
                column: "EmpleadoIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_TareasRealizadas_NominaIdNomina",
                table: "TareasRealizadas",
                column: "NominaIdNomina");

            migrationBuilder.CreateIndex(
                name: "IX_TareasRealizadas_PedidoIdPedido",
                table: "TareasRealizadas",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_TareasRealizadas_TrabajoIdTrabajo",
                table: "TareasRealizadas",
                column: "TrabajoIdTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_TrabajosPedidos_PedidoIdPedido",
                table: "TrabajosPedidos",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_TrabajosPedidos_TrabajoIdTrabajo",
                table: "TrabajosPedidos",
                column: "TrabajoIdTrabajo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TareasRealizadas");

            migrationBuilder.DropTable(
                name: "TrabajosPedidos");

            migrationBuilder.DropTable(
                name: "Nominas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "IdTrabajo",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrabajoIdTrabajo",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TrabajoIdTrabajo",
                table: "Pedidos",
                column: "TrabajoIdTrabajo");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Trabajos_TrabajoIdTrabajo",
                table: "Pedidos",
                column: "TrabajoIdTrabajo",
                principalTable: "Trabajos",
                principalColumn: "IdTrabajo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

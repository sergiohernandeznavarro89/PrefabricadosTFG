using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlturasPisos",
                columns: table => new
                {
                    IdAlturaPiso = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Grosor = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlturasPisos", x => x.IdAlturaPiso);
                });

            migrationBuilder.CreateTable(
                name: "AlturasTapas",
                columns: table => new
                {
                    IdAlturaTapa = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Grosor = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlturasTapas", x => x.IdAlturaTapa);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(nullable: true),
                    NombreComercial = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Provincia = table.Column<string>(nullable: true),
                    Poblacion = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CodPostal = table.Column<int>(nullable: false),
                    DNI = table.Column<string>(nullable: true),
                    CIF = table.Column<string>(nullable: true),
                    Telefono1 = table.Column<int>(nullable: false),
                    Telefono2 = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    IBAN = table.Column<string>(nullable: true),
                    VencimientoFijo = table.Column<DateTime>(nullable: false),
                    Subida = table.Column<int>(nullable: false),
                    Descuento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "ColoresCercos",
                columns: table => new
                {
                    IdColorCerco = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    RGB = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresCercos", x => x.IdColorCerco);
                });

            migrationBuilder.CreateTable(
                name: "ColoresPisos",
                columns: table => new
                {
                    IdColorPiso = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    RGB = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresPisos", x => x.IdColorPiso);
                });

            migrationBuilder.CreateTable(
                name: "ColoresTapas",
                columns: table => new
                {
                    IdColorTapa = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    RGB = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresTapas", x => x.IdColorTapa);
                });

            migrationBuilder.CreateTable(
                name: "ColoresTintados",
                columns: table => new
                {
                    IdColorTintado = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    RGB = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresTintados", x => x.IdColorTintado);
                });

            migrationBuilder.CreateTable(
                name: "FormasPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    NumeroPagos = table.Column<int>(nullable: false),
                    giro = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPago", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "LineasSerie",
                columns: table => new
                {
                    IdLineaSerie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    NumeroDesde = table.Column<int>(nullable: false),
                    NumeroHasta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasSerie", x => x.IdLineaSerie);
                });

            migrationBuilder.CreateTable(
                name: "MaterialesCercos",
                columns: table => new
                {
                    IdMaterialCerco = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialesCercos", x => x.IdMaterialCerco);
                });

            migrationBuilder.CreateTable(
                name: "MaterialesPisos",
                columns: table => new
                {
                    IdMaterialPiso = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialesPisos", x => x.IdMaterialPiso);
                });

            migrationBuilder.CreateTable(
                name: "MaterialesTapas",
                columns: table => new
                {
                    IdMaterialTapa = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialesTapas", x => x.IdMaterialTapa);
                });

            migrationBuilder.CreateTable(
                name: "Remesas",
                columns: table => new
                {
                    IdRemesa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    URLRemesa = table.Column<string>(nullable: true),
                    FechaPresentacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remesas", x => x.IdRemesa);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    IdSerie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.IdSerie);
                });

            migrationBuilder.CreateTable(
                name: "Trabajos",
                columns: table => new
                {
                    IdTrabajo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajos", x => x.IdTrabajo);
                });

            migrationBuilder.CreateTable(
                name: "Hormas",
                columns: table => new
                {
                    IdHorma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hormas", x => x.IdHorma);
                    table.ForeignKey(
                        name: "FK_Hormas_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TroquelesPisos",
                columns: table => new
                {
                    IdTroquelPiso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TroquelesPisos", x => x.IdTroquelPiso);
                    table.ForeignKey(
                        name: "FK_TroquelesPisos_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TroquelesTapas",
                columns: table => new
                {
                    IdTroquelTapa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TroquelesTapas", x => x.IdTroquelTapa);
                    table.ForeignKey(
                        name: "FK_TroquelesTapas_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientesFormasPago",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    FormaPagoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesFormasPago", x => new { x.ClienteId, x.FormaPagoId });
                    table.ForeignKey(
                        name: "FK_ClientesFormasPago_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesFormasPago_FormasPago_FormaPagoId",
                        column: x => x.FormaPagoId,
                        principalTable: "FormasPago",
                        principalColumn: "IdFormaPago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColoresCercoMaterialesCerco",
                columns: table => new
                {
                    MaterialCercoId = table.Column<int>(nullable: false),
                    ColorCercoId = table.Column<int>(nullable: false),
                    MaterialCercoIdMaterialCerco = table.Column<string>(nullable: false),
                    ColorCeroIdColorCerco = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresCercoMaterialesCerco", x => new { x.ColorCercoId, x.MaterialCercoId });
                    table.ForeignKey(
                        name: "FK_ColoresCercoMaterialesCerco_ColoresCercos_ColorCeroIdColorCerco",
                        column: x => x.ColorCeroIdColorCerco,
                        principalTable: "ColoresCercos",
                        principalColumn: "IdColorCerco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColoresCercoMaterialesCerco_MaterialesCercos_MaterialCercoIdMaterialCerco",
                        column: x => x.MaterialCercoIdMaterialCerco,
                        principalTable: "MaterialesCercos",
                        principalColumn: "IdMaterialCerco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlturasPisosMaterialesPisos",
                columns: table => new
                {
                    AlturaPisoId = table.Column<int>(nullable: false),
                    MaterialPisoId = table.Column<int>(nullable: false),
                    AlturaPisoIdAlturaPiso = table.Column<string>(nullable: true),
                    MaterialPisoIdMaterialPiso = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlturasPisosMaterialesPisos", x => new { x.AlturaPisoId, x.MaterialPisoId });
                    table.ForeignKey(
                        name: "FK_AlturasPisosMaterialesPisos_AlturasPisos_AlturaPisoIdAlturaPiso",
                        column: x => x.AlturaPisoIdAlturaPiso,
                        principalTable: "AlturasPisos",
                        principalColumn: "IdAlturaPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlturasPisosMaterialesPisos_MaterialesPisos_MaterialPisoIdMaterialPiso",
                        column: x => x.MaterialPisoIdMaterialPiso,
                        principalTable: "MaterialesPisos",
                        principalColumn: "IdMaterialPiso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColoresPisosMaterialesPisos",
                columns: table => new
                {
                    ColorPisoId = table.Column<int>(nullable: false),
                    MaterialPisoId = table.Column<int>(nullable: false),
                    ColorPisoIdColorPiso = table.Column<string>(nullable: true),
                    MaterialPisoIdMaterialPiso = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresPisosMaterialesPisos", x => new { x.ColorPisoId, x.MaterialPisoId });
                    table.ForeignKey(
                        name: "FK_ColoresPisosMaterialesPisos_ColoresPisos_ColorPisoIdColorPiso",
                        column: x => x.ColorPisoIdColorPiso,
                        principalTable: "ColoresPisos",
                        principalColumn: "IdColorPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColoresPisosMaterialesPisos_MaterialesPisos_MaterialPisoIdMaterialPiso",
                        column: x => x.MaterialPisoIdMaterialPiso,
                        principalTable: "MaterialesPisos",
                        principalColumn: "IdMaterialPiso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlturasTapasMaterialesTapas",
                columns: table => new
                {
                    AlturaTapaId = table.Column<int>(nullable: false),
                    MaterialTapaId = table.Column<int>(nullable: false),
                    AlturaTapaIdAlturaTapa = table.Column<string>(nullable: true),
                    MaterialTapaIdMaterialTapa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlturasTapasMaterialesTapas", x => new { x.AlturaTapaId, x.MaterialTapaId });
                    table.ForeignKey(
                        name: "FK_AlturasTapasMaterialesTapas_AlturasTapas_AlturaTapaIdAlturaTapa",
                        column: x => x.AlturaTapaIdAlturaTapa,
                        principalTable: "AlturasTapas",
                        principalColumn: "IdAlturaTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlturasTapasMaterialesTapas_MaterialesTapas_MaterialTapaIdMaterialTapa",
                        column: x => x.MaterialTapaIdMaterialTapa,
                        principalTable: "MaterialesTapas",
                        principalColumn: "IdMaterialTapa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColoresTapasMaterialesTapas",
                columns: table => new
                {
                    ColorTapaId = table.Column<int>(nullable: false),
                    MaterialTapaId = table.Column<int>(nullable: false),
                    ColorTapaIdColorTapa = table.Column<string>(nullable: true),
                    MaterialTapaIdMaterialTapa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresTapasMaterialesTapas", x => new { x.ColorTapaId, x.MaterialTapaId });
                    table.ForeignKey(
                        name: "FK_ColoresTapasMaterialesTapas_ColoresTapas_ColorTapaIdColorTapa",
                        column: x => x.ColorTapaIdColorTapa,
                        principalTable: "ColoresTapas",
                        principalColumn: "IdColorTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColoresTapasMaterialesTapas_MaterialesTapas_MaterialTapaIdMaterialTapa",
                        column: x => x.MaterialTapaIdMaterialTapa,
                        principalTable: "MaterialesTapas",
                        principalColumn: "IdMaterialTapa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RemesaCliente",
                columns: table => new
                {
                    RemesaId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemesaCliente", x => new { x.RemesaId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_RemesaCliente_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RemesaCliente_Remesas_RemesaId",
                        column: x => x.RemesaId,
                        principalTable: "Remesas",
                        principalColumn: "IdRemesa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasSerieSerie",
                columns: table => new
                {
                    LineaSerieId = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasSerieSerie", x => new { x.LineaSerieId, x.SerieId });
                    table.ForeignKey(
                        name: "FK_LineasSerieSerie_LineasSerie_LineaSerieId",
                        column: x => x.LineaSerieId,
                        principalTable: "LineasSerie",
                        principalColumn: "IdLineaSerie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasSerieSerie_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "IdSerie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HormasTroquelesPisos",
                columns: table => new
                {
                    HormaId = table.Column<int>(nullable: false),
                    TroquelPisoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HormasTroquelesPisos", x => new { x.HormaId, x.TroquelPisoId });
                    table.ForeignKey(
                        name: "FK_HormasTroquelesPisos_Hormas_HormaId",
                        column: x => x.HormaId,
                        principalTable: "Hormas",
                        principalColumn: "IdHorma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HormasTroquelesPisos_TroquelesPisos_TroquelPisoId",
                        column: x => x.TroquelPisoId,
                        principalTable: "TroquelesPisos",
                        principalColumn: "IdTroquelPiso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escandallos",
                columns: table => new
                {
                    IdEscandallo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true),
                    DescuentoPrecio = table.Column<int>(nullable: false),
                    SubidaPrecio = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true),
                    IdHorma = table.Column<int>(nullable: false),
                    HormaIdHorma = table.Column<int>(nullable: true),
                    IdTroquelPiso = table.Column<int>(nullable: false),
                    TroquelPisoIdTroquelPiso = table.Column<int>(nullable: true),
                    IdTroquelTapa = table.Column<int>(nullable: false),
                    TroquelTapaIdTroquelTapa = table.Column<int>(nullable: true),
                    IdAlturaPiso = table.Column<int>(nullable: false),
                    AlturaPisoIdAlturaPiso = table.Column<string>(nullable: true),
                    IdAlturaTapa = table.Column<int>(nullable: false),
                    AlturaTapaIdAlturaTapa = table.Column<string>(nullable: true),
                    IdColorCerco = table.Column<int>(nullable: false),
                    ColorCercoIdColorCerco = table.Column<string>(nullable: true),
                    IdColorPiso = table.Column<int>(nullable: false),
                    ColorPîsoIdColorPiso = table.Column<string>(nullable: true),
                    IdColorTapa = table.Column<int>(nullable: false),
                    ColorTapaIdColorTapa = table.Column<string>(nullable: true),
                    IdColorTintado = table.Column<int>(nullable: false),
                    ColorTintadoIdColorTintado = table.Column<string>(nullable: true),
                    IdMaterialCerco = table.Column<int>(nullable: false),
                    MaterialCercoIdMaterialCerco = table.Column<string>(nullable: true),
                    IdMaterialPiso = table.Column<int>(nullable: false),
                    MaterialPisoIdMaterialPiso = table.Column<string>(nullable: true),
                    IdMaterialTapa = table.Column<int>(nullable: false),
                    MaterialTapaIdMaterialTapa = table.Column<string>(nullable: true),
                    IdTrabajo = table.Column<int>(nullable: false),
                    TrabajoIdTrabajo = table.Column<int>(nullable: true),
                    IdSerie = table.Column<int>(nullable: false),
                    SerieIdSerie = table.Column<int>(nullable: true),
                    LineasSerie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escandallos", x => x.IdEscandallo);
                    table.ForeignKey(
                        name: "FK_Escandallos_AlturasPisos_AlturaPisoIdAlturaPiso",
                        column: x => x.AlturaPisoIdAlturaPiso,
                        principalTable: "AlturasPisos",
                        principalColumn: "IdAlturaPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_AlturasTapas_AlturaTapaIdAlturaTapa",
                        column: x => x.AlturaTapaIdAlturaTapa,
                        principalTable: "AlturasTapas",
                        principalColumn: "IdAlturaTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_ColoresCercos_ColorCercoIdColorCerco",
                        column: x => x.ColorCercoIdColorCerco,
                        principalTable: "ColoresCercos",
                        principalColumn: "IdColorCerco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_ColoresPisos_ColorPîsoIdColorPiso",
                        column: x => x.ColorPîsoIdColorPiso,
                        principalTable: "ColoresPisos",
                        principalColumn: "IdColorPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_ColoresTapas_ColorTapaIdColorTapa",
                        column: x => x.ColorTapaIdColorTapa,
                        principalTable: "ColoresTapas",
                        principalColumn: "IdColorTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_ColoresTintados_ColorTintadoIdColorTintado",
                        column: x => x.ColorTintadoIdColorTintado,
                        principalTable: "ColoresTintados",
                        principalColumn: "IdColorTintado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_Hormas_HormaIdHorma",
                        column: x => x.HormaIdHorma,
                        principalTable: "Hormas",
                        principalColumn: "IdHorma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_MaterialesCercos_MaterialCercoIdMaterialCerco",
                        column: x => x.MaterialCercoIdMaterialCerco,
                        principalTable: "MaterialesCercos",
                        principalColumn: "IdMaterialCerco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_MaterialesPisos_MaterialPisoIdMaterialPiso",
                        column: x => x.MaterialPisoIdMaterialPiso,
                        principalTable: "MaterialesPisos",
                        principalColumn: "IdMaterialPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_MaterialesTapas_MaterialTapaIdMaterialTapa",
                        column: x => x.MaterialTapaIdMaterialTapa,
                        principalTable: "MaterialesTapas",
                        principalColumn: "IdMaterialTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_Series_SerieIdSerie",
                        column: x => x.SerieIdSerie,
                        principalTable: "Series",
                        principalColumn: "IdSerie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_Trabajos_TrabajoIdTrabajo",
                        column: x => x.TrabajoIdTrabajo,
                        principalTable: "Trabajos",
                        principalColumn: "IdTrabajo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_TroquelesPisos_TroquelPisoIdTroquelPiso",
                        column: x => x.TroquelPisoIdTroquelPiso,
                        principalTable: "TroquelesPisos",
                        principalColumn: "IdTroquelPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escandallos_TroquelesTapas_TroquelTapaIdTroquelTapa",
                        column: x => x.TroquelTapaIdTroquelTapa,
                        principalTable: "TroquelesTapas",
                        principalColumn: "IdTroquelTapa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HormasTroquelesTapas",
                columns: table => new
                {
                    HormaId = table.Column<int>(nullable: false),
                    TroquelTapaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HormasTroquelesTapas", x => new { x.HormaId, x.TroquelTapaId });
                    table.ForeignKey(
                        name: "FK_HormasTroquelesTapas_Hormas_HormaId",
                        column: x => x.HormaId,
                        principalTable: "Hormas",
                        principalColumn: "IdHorma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HormasTroquelesTapas_TroquelesTapas_TroquelTapaId",
                        column: x => x.TroquelTapaId,
                        principalTable: "TroquelesTapas",
                        principalColumn: "IdTroquelTapa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(nullable: false),
                    FechaServicio = table.Column<DateTime>(nullable: false),
                    CodigoPedidoCliente = table.Column<string>(nullable: true),
                    PrecioTotal = table.Column<int>(nullable: false),
                    IdFormaPago = table.Column<int>(nullable: false),
                    FormaPagoIdFormaPago = table.Column<int>(nullable: true),
                    IdTrabajo = table.Column<int>(nullable: false),
                    TrabajoIdTrabajo = table.Column<int>(nullable: true),
                    IdMaterialPiso = table.Column<int>(nullable: false),
                    MaterialPisoIdMaterialPiso = table.Column<string>(nullable: true),
                    IdAlturaPiso = table.Column<int>(nullable: false),
                    AlturaPisoIdAlturaPiso = table.Column<string>(nullable: true),
                    IdColorPiso = table.Column<int>(nullable: false),
                    ColorPisoIdColorPiso = table.Column<string>(nullable: true),
                    IdMaterialTapa = table.Column<int>(nullable: false),
                    MaterialTapaIdMaterialTapa = table.Column<string>(nullable: true),
                    IdAlturaTapa = table.Column<int>(nullable: false),
                    AlturaTapaIdAlturaTapa = table.Column<string>(nullable: true),
                    IdColorTapa = table.Column<int>(nullable: false),
                    ColorTapaIdColorTapa = table.Column<string>(nullable: true),
                    IdMaterialCerco = table.Column<int>(nullable: false),
                    MaterialCercoIdMaterialCerco = table.Column<string>(nullable: true),
                    IdColorCerco = table.Column<int>(nullable: false),
                    ColorCercoIdColorCerco = table.Column<string>(nullable: true),
                    IdHorma = table.Column<int>(nullable: false),
                    HormaIdHorma = table.Column<int>(nullable: true),
                    IdTroquelPiso = table.Column<int>(nullable: false),
                    TroquelPisoIdTroquelPiso = table.Column<int>(nullable: true),
                    IdTroquelTapa = table.Column<int>(nullable: false),
                    TroquelTapaIdTroquelTapa = table.Column<int>(nullable: true),
                    IdColorTintado = table.Column<int>(nullable: false),
                    ColorTintadoIdColorTintado = table.Column<string>(nullable: true),
                    IdSerie = table.Column<int>(nullable: false),
                    SerieIdSerie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_AlturasPisos_AlturaPisoIdAlturaPiso",
                        column: x => x.AlturaPisoIdAlturaPiso,
                        principalTable: "AlturasPisos",
                        principalColumn: "IdAlturaPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_AlturasTapas_AlturaTapaIdAlturaTapa",
                        column: x => x.AlturaTapaIdAlturaTapa,
                        principalTable: "AlturasTapas",
                        principalColumn: "IdAlturaTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_ColoresCercos_ColorCercoIdColorCerco",
                        column: x => x.ColorCercoIdColorCerco,
                        principalTable: "ColoresCercos",
                        principalColumn: "IdColorCerco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_ColoresPisos_ColorPisoIdColorPiso",
                        column: x => x.ColorPisoIdColorPiso,
                        principalTable: "ColoresPisos",
                        principalColumn: "IdColorPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_ColoresTapas_ColorTapaIdColorTapa",
                        column: x => x.ColorTapaIdColorTapa,
                        principalTable: "ColoresTapas",
                        principalColumn: "IdColorTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_ColoresTintados_ColorTintadoIdColorTintado",
                        column: x => x.ColorTintadoIdColorTintado,
                        principalTable: "ColoresTintados",
                        principalColumn: "IdColorTintado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_FormasPago_FormaPagoIdFormaPago",
                        column: x => x.FormaPagoIdFormaPago,
                        principalTable: "FormasPago",
                        principalColumn: "IdFormaPago",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Hormas_HormaIdHorma",
                        column: x => x.HormaIdHorma,
                        principalTable: "Hormas",
                        principalColumn: "IdHorma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_MaterialesCercos_MaterialCercoIdMaterialCerco",
                        column: x => x.MaterialCercoIdMaterialCerco,
                        principalTable: "MaterialesCercos",
                        principalColumn: "IdMaterialCerco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_MaterialesPisos_MaterialPisoIdMaterialPiso",
                        column: x => x.MaterialPisoIdMaterialPiso,
                        principalTable: "MaterialesPisos",
                        principalColumn: "IdMaterialPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_MaterialesTapas_MaterialTapaIdMaterialTapa",
                        column: x => x.MaterialTapaIdMaterialTapa,
                        principalTable: "MaterialesTapas",
                        principalColumn: "IdMaterialTapa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Series_SerieIdSerie",
                        column: x => x.SerieIdSerie,
                        principalTable: "Series",
                        principalColumn: "IdSerie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Trabajos_TrabajoIdTrabajo",
                        column: x => x.TrabajoIdTrabajo,
                        principalTable: "Trabajos",
                        principalColumn: "IdTrabajo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_TroquelesPisos_TroquelPisoIdTroquelPiso",
                        column: x => x.TroquelPisoIdTroquelPiso,
                        principalTable: "TroquelesPisos",
                        principalColumn: "IdTroquelPiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_TroquelesTapas_TroquelTapaIdTroquelTapa",
                        column: x => x.TroquelTapaIdTroquelTapa,
                        principalTable: "TroquelesTapas",
                        principalColumn: "IdTroquelTapa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineasSerieEscandallos",
                columns: table => new
                {
                    LineaSerieId = table.Column<int>(nullable: false),
                    EscandalloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasSerieEscandallos", x => new { x.LineaSerieId, x.EscandalloId });
                    table.ForeignKey(
                        name: "FK_LineasSerieEscandallos_Escandallos_EscandalloId",
                        column: x => x.EscandalloId,
                        principalTable: "Escandallos",
                        principalColumn: "IdEscandallo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasSerieEscandallos_LineasSerie_LineaSerieId",
                        column: x => x.LineaSerieId,
                        principalTable: "LineasSerie",
                        principalColumn: "IdLineaSerie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Albaranes",
                columns: table => new
                {
                    IdAlbaran = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaFirma = table.Column<DateTime>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albaranes", x => x.IdAlbaran);
                    table.ForeignKey(
                        name: "FK_Albaranes_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cobros",
                columns: table => new
                {
                    IdCobro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCobroPrevista = table.Column<DateTime>(nullable: false),
                    FechaRealizacionCobro = table.Column<DateTime>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false),
                    PedidoIdPedido = table.Column<int>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true),
                    IdRemesa = table.Column<int>(nullable: false),
                    RemesaIdRemesa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobros", x => x.IdCobro);
                    table.ForeignKey(
                        name: "FK_Cobros_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cobros_Pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cobros_Remesas_RemesaIdRemesa",
                        column: x => x.RemesaIdRemesa,
                        principalTable: "Remesas",
                        principalColumn: "IdRemesa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EscandallosPedidos",
                columns: table => new
                {
                    EscandalloId = table.Column<int>(nullable: false),
                    PedidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscandallosPedidos", x => new { x.EscandalloId, x.PedidoId });
                    table.ForeignKey(
                        name: "FK_EscandallosPedidos_Escandallos_EscandalloId",
                        column: x => x.EscandalloId,
                        principalTable: "Escandallos",
                        principalColumn: "IdEscandallo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EscandallosPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaFirma = table.Column<DateTime>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Facturas_Pedidos_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineasSeriePedidos",
                columns: table => new
                {
                    LineaSerieId = table.Column<int>(nullable: false),
                    PedidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineasSeriePedidos", x => new { x.LineaSerieId, x.PedidoId });
                    table.ForeignKey(
                        name: "FK_LineasSeriePedidos_LineasSerie_LineaSerieId",
                        column: x => x.LineaSerieId,
                        principalTable: "LineasSerie",
                        principalColumn: "IdLineaSerie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineasSeriePedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albaranes_IdPedido",
                table: "Albaranes",
                column: "IdPedido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlturasPisosMaterialesPisos_AlturaPisoIdAlturaPiso",
                table: "AlturasPisosMaterialesPisos",
                column: "AlturaPisoIdAlturaPiso");

            migrationBuilder.CreateIndex(
                name: "IX_AlturasPisosMaterialesPisos_MaterialPisoIdMaterialPiso",
                table: "AlturasPisosMaterialesPisos",
                column: "MaterialPisoIdMaterialPiso");

            migrationBuilder.CreateIndex(
                name: "IX_AlturasTapasMaterialesTapas_AlturaTapaIdAlturaTapa",
                table: "AlturasTapasMaterialesTapas",
                column: "AlturaTapaIdAlturaTapa");

            migrationBuilder.CreateIndex(
                name: "IX_AlturasTapasMaterialesTapas_MaterialTapaIdMaterialTapa",
                table: "AlturasTapasMaterialesTapas",
                column: "MaterialTapaIdMaterialTapa");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesFormasPago_FormaPagoId",
                table: "ClientesFormasPago",
                column: "FormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cobros_ClienteIdCliente",
                table: "Cobros",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cobros_PedidoIdPedido",
                table: "Cobros",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Cobros_RemesaIdRemesa",
                table: "Cobros",
                column: "RemesaIdRemesa");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresCercoMaterialesCerco_ColorCeroIdColorCerco",
                table: "ColoresCercoMaterialesCerco",
                column: "ColorCeroIdColorCerco");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresCercoMaterialesCerco_MaterialCercoIdMaterialCerco",
                table: "ColoresCercoMaterialesCerco",
                column: "MaterialCercoIdMaterialCerco");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresPisosMaterialesPisos_ColorPisoIdColorPiso",
                table: "ColoresPisosMaterialesPisos",
                column: "ColorPisoIdColorPiso");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresPisosMaterialesPisos_MaterialPisoIdMaterialPiso",
                table: "ColoresPisosMaterialesPisos",
                column: "MaterialPisoIdMaterialPiso");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresTapasMaterialesTapas_ColorTapaIdColorTapa",
                table: "ColoresTapasMaterialesTapas",
                column: "ColorTapaIdColorTapa");

            migrationBuilder.CreateIndex(
                name: "IX_ColoresTapasMaterialesTapas_MaterialTapaIdMaterialTapa",
                table: "ColoresTapasMaterialesTapas",
                column: "MaterialTapaIdMaterialTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_AlturaPisoIdAlturaPiso",
                table: "Escandallos",
                column: "AlturaPisoIdAlturaPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_AlturaTapaIdAlturaTapa",
                table: "Escandallos",
                column: "AlturaTapaIdAlturaTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_ClienteIdCliente",
                table: "Escandallos",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_ColorCercoIdColorCerco",
                table: "Escandallos",
                column: "ColorCercoIdColorCerco");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_ColorPîsoIdColorPiso",
                table: "Escandallos",
                column: "ColorPîsoIdColorPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_ColorTapaIdColorTapa",
                table: "Escandallos",
                column: "ColorTapaIdColorTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_ColorTintadoIdColorTintado",
                table: "Escandallos",
                column: "ColorTintadoIdColorTintado");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_HormaIdHorma",
                table: "Escandallos",
                column: "HormaIdHorma");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_MaterialCercoIdMaterialCerco",
                table: "Escandallos",
                column: "MaterialCercoIdMaterialCerco");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_MaterialPisoIdMaterialPiso",
                table: "Escandallos",
                column: "MaterialPisoIdMaterialPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_MaterialTapaIdMaterialTapa",
                table: "Escandallos",
                column: "MaterialTapaIdMaterialTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_SerieIdSerie",
                table: "Escandallos",
                column: "SerieIdSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_TrabajoIdTrabajo",
                table: "Escandallos",
                column: "TrabajoIdTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_TroquelPisoIdTroquelPiso",
                table: "Escandallos",
                column: "TroquelPisoIdTroquelPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Escandallos_TroquelTapaIdTroquelTapa",
                table: "Escandallos",
                column: "TroquelTapaIdTroquelTapa");

            migrationBuilder.CreateIndex(
                name: "IX_EscandallosPedidos_PedidoId",
                table: "EscandallosPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_IdPedido",
                table: "Facturas",
                column: "IdPedido",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hormas_ClienteIdCliente",
                table: "Hormas",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_HormasTroquelesPisos_TroquelPisoId",
                table: "HormasTroquelesPisos",
                column: "TroquelPisoId");

            migrationBuilder.CreateIndex(
                name: "IX_HormasTroquelesTapas_TroquelTapaId",
                table: "HormasTroquelesTapas",
                column: "TroquelTapaId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasSerieEscandallos_EscandalloId",
                table: "LineasSerieEscandallos",
                column: "EscandalloId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasSeriePedidos_PedidoId",
                table: "LineasSeriePedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_LineasSerieSerie_SerieId",
                table: "LineasSerieSerie",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_AlturaPisoIdAlturaPiso",
                table: "Pedidos",
                column: "AlturaPisoIdAlturaPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_AlturaTapaIdAlturaTapa",
                table: "Pedidos",
                column: "AlturaTapaIdAlturaTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ColorCercoIdColorCerco",
                table: "Pedidos",
                column: "ColorCercoIdColorCerco");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ColorPisoIdColorPiso",
                table: "Pedidos",
                column: "ColorPisoIdColorPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ColorTapaIdColorTapa",
                table: "Pedidos",
                column: "ColorTapaIdColorTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ColorTintadoIdColorTintado",
                table: "Pedidos",
                column: "ColorTintadoIdColorTintado");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_FormaPagoIdFormaPago",
                table: "Pedidos",
                column: "FormaPagoIdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_HormaIdHorma",
                table: "Pedidos",
                column: "HormaIdHorma");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MaterialCercoIdMaterialCerco",
                table: "Pedidos",
                column: "MaterialCercoIdMaterialCerco");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MaterialPisoIdMaterialPiso",
                table: "Pedidos",
                column: "MaterialPisoIdMaterialPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MaterialTapaIdMaterialTapa",
                table: "Pedidos",
                column: "MaterialTapaIdMaterialTapa");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_SerieIdSerie",
                table: "Pedidos",
                column: "SerieIdSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TrabajoIdTrabajo",
                table: "Pedidos",
                column: "TrabajoIdTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TroquelPisoIdTroquelPiso",
                table: "Pedidos",
                column: "TroquelPisoIdTroquelPiso");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TroquelTapaIdTroquelTapa",
                table: "Pedidos",
                column: "TroquelTapaIdTroquelTapa");

            migrationBuilder.CreateIndex(
                name: "IX_RemesaCliente_ClienteId",
                table: "RemesaCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TroquelesPisos_ClienteIdCliente",
                table: "TroquelesPisos",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TroquelesTapas_ClienteIdCliente",
                table: "TroquelesTapas",
                column: "ClienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albaranes");

            migrationBuilder.DropTable(
                name: "AlturasPisosMaterialesPisos");

            migrationBuilder.DropTable(
                name: "AlturasTapasMaterialesTapas");

            migrationBuilder.DropTable(
                name: "ClientesFormasPago");

            migrationBuilder.DropTable(
                name: "Cobros");

            migrationBuilder.DropTable(
                name: "ColoresCercoMaterialesCerco");

            migrationBuilder.DropTable(
                name: "ColoresPisosMaterialesPisos");

            migrationBuilder.DropTable(
                name: "ColoresTapasMaterialesTapas");

            migrationBuilder.DropTable(
                name: "EscandallosPedidos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "HormasTroquelesPisos");

            migrationBuilder.DropTable(
                name: "HormasTroquelesTapas");

            migrationBuilder.DropTable(
                name: "LineasSerieEscandallos");

            migrationBuilder.DropTable(
                name: "LineasSeriePedidos");

            migrationBuilder.DropTable(
                name: "LineasSerieSerie");

            migrationBuilder.DropTable(
                name: "RemesaCliente");

            migrationBuilder.DropTable(
                name: "Escandallos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "LineasSerie");

            migrationBuilder.DropTable(
                name: "Remesas");

            migrationBuilder.DropTable(
                name: "AlturasPisos");

            migrationBuilder.DropTable(
                name: "AlturasTapas");

            migrationBuilder.DropTable(
                name: "ColoresCercos");

            migrationBuilder.DropTable(
                name: "ColoresPisos");

            migrationBuilder.DropTable(
                name: "ColoresTapas");

            migrationBuilder.DropTable(
                name: "ColoresTintados");

            migrationBuilder.DropTable(
                name: "FormasPago");

            migrationBuilder.DropTable(
                name: "Hormas");

            migrationBuilder.DropTable(
                name: "MaterialesCercos");

            migrationBuilder.DropTable(
                name: "MaterialesPisos");

            migrationBuilder.DropTable(
                name: "MaterialesTapas");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Trabajos");

            migrationBuilder.DropTable(
                name: "TroquelesPisos");

            migrationBuilder.DropTable(
                name: "TroquelesTapas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

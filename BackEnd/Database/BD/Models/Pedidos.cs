using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Pedidos
    {
        [Key]
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaServicio { get; set; }
        public string CodigoPedidoCliente { get; set; }
        public int PrecioTotal { get; set; }



        //RELACIONES
        //Relacion con tabla formas de pago (1 cliente N forma de pago : 1 forma de pago N clientes)
        [ForeignKey("IdFormaPago")]
        public int IdFormaPago { get; set; }
        public FormasPago FormaPago { get; set; }
        //-------------

        //relación con la tabla Trabajos (1 Escandallo 1 Trabajo : 1 Trabajo N Escandallos)
        [ForeignKey("IdTrabajo")]
        public int IdTrabajo { get; set; }
        public Trabajos Trabajo { get; set; }
        //-------------

        //relación con la tabla MaterialesPisos (1 Pedido 1 Material piso : 1 Material piso N Pedidos)
        [ForeignKey("IdMaterialPiso")]
        public int IdMaterialPiso { get; set; }
        public MaterialesPisos MaterialPiso { get; set; }
        //-------------

        //relación con la tabla AlturasPiso (1 Pedido 1 AlturaPiso : 1 AlturaPiso N Pedidos) 
        [ForeignKey("IdAlturaPiso")]
        public int IdAlturaPiso { get; set; }
        public AlturasPisos AlturaPiso { get; set; }
        //-------------

        //relación con la tabla ColorPiso (1 Pedido 1 Color piso : 1 Color piso N Pedidos)
        [ForeignKey("IdColorPiso")]
        public int IdColorPiso { get; set; }
        public ColoresPisos ColorPiso { get; set; }
        //-------------

        //relación con la tabla MaterialesTapas (1 Escandallo 1 Material tapas : 1 Material tapas N Escandallos)
        [ForeignKey("IdMaterialTapa")]
        public int IdMaterialTapa { get; set; }
        public MaterialesTapas MaterialTapa { get; set; }
        //-------------

        //relación con la tabla AlturasTapas (1 Escandallo 1 AlturasTapas : 1 AlturasTapas N Escandallos) según la serie del cliente elegida
        [ForeignKey("IdAlturaTapa")]
        public int IdAlturaTapa { get; set; }
        public AlturasTapas AlturaTapa { get; set; }
        //-------------

        //relación con la tabla ColorTapa (1 Escandallo 1 Color tapa : 1 Color tapa N Escandallos)
        [ForeignKey("IdColorTapa")]
        public int IdColorTapa { get; set; }
        public ColoresTapas ColorTapa { get; set; }
        //-------------

        //relación con la tabla MaterialesCercos (1 Escandallo 1 Material cerco : 1 Material cerco N Escandallos)
        [ForeignKey("IdMaterialCerco")]
        public int IdMaterialCerco { get; set; }
        public MaterialesCercos MaterialCerco { get; set; }

        //relación con la tabla ColorCerco (1 Escandallo 1 Color Cerco : 1 Color cerco N Escandallos)
        [ForeignKey("IdColorCerco")]
        public int IdColorCerco { get; set; }
        public ColoresCercos ColorCerco { get; set; }
        //-------------

        //relación con la tabla Hormas (1 Escandallo 1 Horma : 1 Horma N Escandallos)
        [ForeignKey("IdHorma")]
        public int IdHorma { get; set; }
        public Hormas Horma { get; set; }
        //-------------

        //relación con la tabla Troqueles (1 Escandallo 1 Troquel : 1 Troquel N Escandallos)
        [ForeignKey("IdTroquelPiso")]
        public int IdTroquelPiso { get; set; }
        public TroquelesPisos TroquelPiso { get; set; }
        //-------------

        //relación con la tabla Troqueles (1 Escandallo 1 Troquel : 1 Troquel N Escandallos)
        [ForeignKey("IdTroquelTapa")]
        public int IdTroquelTapa { get; set; }
        public TroquelesTapas TroquelTapa { get; set; }
        //-------------

        //relación con la tabla Hormas (1 Escandallo 1 Horma : 1 Horma N Escandallos)
        [ForeignKey("IdColorTintado")]
        public int IdColorTintado { get; set; }
        public ColoresTintado ColorTintado { get; set; }
        //-------------

        //relación con la tabla Series (1 Escandallo 1 Serie : 1 Serie N Escandallos)               
        [ForeignKey("IdSerie")]
        public int IdSerie { get; set; }
        public Series Serie { get; set; }
        //-------------



        public string LineasSerie { get; set; } //relación con la tabla LineasSeries (1 Escandallo N LineasSerie : 1 LineaSerie N Escandallos)
        public string Escandallo { get; set; } //relación con la tabla Escandallos (1 Pedido N Escandallo : 1 Escandallo N Pedidos)
    }
}

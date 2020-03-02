using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaServicio { get; set; }
        public string CodigoPedidoCliente { get; set; }
        public int PrecioTotal { get; set; }


        #region RELACIONES
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        //--------------------
        [ForeignKey("IdFormaPago")]
        public int IdFormaPago { get; set; }
        public FormaPago FormaPago { get; set; }
        //-------------
        [ForeignKey("IdTrabajo")]
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }
        //-------------
        [ForeignKey("IdMaterialPiso")]
        public int IdMaterialPiso { get; set; }
        public MaterialPiso MaterialPiso { get; set; }
        //-------------
        [ForeignKey("IdAlturaPiso")]
        public int IdAlturaPiso { get; set; }
        public AlturaPiso AlturaPiso { get; set; }
        //-------------
        [ForeignKey("IdColorPiso")]
        public int IdColorPiso { get; set; }
        public ColorPiso ColorPiso { get; set; }
        //-------------
        [ForeignKey("IdMaterialTapa")]
        public int IdMaterialTapa { get; set; }
        public MaterialTapa MaterialTapa { get; set; }
        //-------------
        [ForeignKey("IdAlturaTapa")]
        public int IdAlturaTapa { get; set; }
        public AlturaTapa AlturaTapa { get; set; }
        //-------------
        [ForeignKey("IdColorTapa")]
        public int IdColorTapa { get; set; }
        public ColorTapa ColorTapa { get; set; }
        //-------------
        [ForeignKey("IdMaterialCerco")]
        public int IdMaterialCerco { get; set; }
        public MaterialCerco MaterialCerco { get; set; }
        //-----------
        [ForeignKey("IdColorCerco")]
        public int IdColorCerco { get; set; }
        public ColorCerco ColorCerco { get; set; }
        //-------------
        [ForeignKey("IdHorma")]
        public int IdHorma { get; set; }
        public Horma Horma { get; set; }
        //-------------
        [ForeignKey("IdTroquelPiso")]
        public int IdTroquelPiso { get; set; }
        public TroquelPiso TroquelPiso { get; set; }
        //-------------
        public int IdTroquelTapa { get; set; }
        public TroquelTapa TroquelTapa { get; set; }
        //-------------
        [ForeignKey("IdColorTintado")]
        public int IdColorTintado { get; set; }
        public ColorTintado ColorTintado { get; set; }
        //-------------
        [ForeignKey("IdSerie")]
        public int IdSerie { get; set; }
        public Serie Serie { get; set; }
        //-------------                    
        public Albaran Albaran { get; set; }
        //-------------
        public Factura Factura { get; set; }
        //-------------

        public ICollection<LineaSeriePedido> LineasSeriePedidos { get; set; }
        public ICollection<EscandalloPedido> EscandallosPedidos { get; set; }
        public ICollection<Cobro> Cobros { get; set; }
        #endregion                
    }
}

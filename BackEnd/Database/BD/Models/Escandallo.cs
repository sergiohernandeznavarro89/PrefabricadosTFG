using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Escandallo
    {
        [Key]
        public int IdEscandallo { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public int DescuentoPrecio { get; set; }
        public int SubidaPrecio { get; set; }



        #region RELACIONES
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        //-------------
        [ForeignKey("IdHorma")]
        public int IdHorma { get; set; }
        public Horma Horma { get; set; }
        //-------------
        [ForeignKey("IdTroquelPiso")]
        public int IdTroquelPiso { get; set; }
        public TroquelPiso TroquelPiso { get; set; }
        //-------------
        [ForeignKey("IdTroquelTapa")]
        public int IdTroquelTapa { get; set; }
        public TroquelTapa TroquelTapa { get; set; }
        //-------------        
        [ForeignKey("IdAlturaPiso")]
        public int IdAlturaPiso { get; set; }
        public AlturaPiso AlturaPiso { get; set; }
        //-------------        
        [ForeignKey("IdAlturaTapa")]
        public int IdAlturaTapa { get; set; }
        public AlturaTapa AlturaTapa { get; set; }
        //-------------
        [ForeignKey("IdColorCerco")]
        public int IdColorCerco { get; set; }
        public ColorCerco ColorCerco { get; set; }
        //-------------        
        [ForeignKey("IdColorPiso")]
        public int IdColorPiso { get; set; }
        public ColorPiso ColorPîso { get; set; }
        //-------------
        [ForeignKey("IdColorTapa")]
        public int IdColorTapa { get; set; }
        public ColorTapa ColorTapa { get; set; }
        //-------------
        [ForeignKey("IdColorTintado")]
        public int IdColorTintado { get; set; }
        public ColorTintado ColorTintado { get; set; }
        //-------------
        [ForeignKey("IdMaterialCerco")]
        public int IdMaterialCerco { get; set; }
        public MaterialCerco MaterialCerco { get; set; }
        //-------------
        [ForeignKey("IdMaterialPiso")]
        public int IdMaterialPiso { get; set; }
        public MaterialPiso MaterialPiso { get; set; }
        //-------------
        [ForeignKey("IdMaterialTapa")]
        public int IdMaterialTapa { get; set; }
        public MaterialTapa MaterialTapa { get; set; }
        //-------------
        [ForeignKey("IdTrabajo")]
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }
        //-------------
        [ForeignKey("IdSerie")]
        public int IdSerie { get; set; }
        public Serie Serie { get; set; }
        //-------------
        public ICollection<EscandalloPedido> EscandallosPedidos { get; set; }
        public ICollection<LineaSerieEscandallo> LineasSerieEscandallos { get; set; }
        #endregion





        public string LineasSerie { get; set; } //relación con la tabla LineasSeries (1 Escandallo N LineasSerie : 1 LineaSerie N Escandallos)
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Escandallos
    {
        [Key]
        public int IdEscandallo { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public int DescuentoPrecio { get; set; }
        public int SubidaPrecio { get; set; }



        //RELACIONES        

        //relación con la tabla Clientes (1 Escandallo 1 Cliente : 1 Cliente N Escandallos)
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
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

        //relación con la tabla AlturasPiso (1 Escandallo 1 AlturaPiso : 1 AlturaPiso N Escandallos) según la serie del cliente elegida
        [ForeignKey("IdAlturaPiso")]
        public int IdAlturaPiso { get; set; }
        public AlturasPisos AlturaPiso { get; set; }
        //-------------

        //relación con la tabla AlturasTapas (1 Escandallo 1 AlturasTapas : 1 AlturasTapas N Escandallos) según la serie del cliente elegida
        [ForeignKey("IdAlturaTapa")]
        public int IdAlturaTapa { get; set; }
        public AlturasTapas AlturaTapa { get; set; }
        //-------------

        //relación con la tabla ColorCerco (1 Escandallo 1 Color Cerco : 1 Color cerco N Escandallos)
        [ForeignKey("IdColorCerco")]
        public int IdColorCerco { get; set; }
        public ColoresCercos ColorCerco { get; set; }
        //-------------

        //relación con la tabla ColorPiso (1 Escandallo 1 Color piso : 1 Color piso N Escandallos)
        [ForeignKey("IdColorPiso")]
        public int IdColorPiso { get; set; }
        public ColoresPisos ColorPîso { get; set; }
        //-------------

        //relación con la tabla ColorTapa (1 Escandallo 1 Color tapa : 1 Color tapa N Escandallos)
        [ForeignKey("IdColorTapa")]
        public int IdColorTapa { get; set; }
        public ColoresTapas ColorTapa { get; set; }
        //-------------

        //relación con la tabla Hormas (1 Escandallo 1 Horma : 1 Horma N Escandallos)
        [ForeignKey("IdColorTintado")]
        public int IdColorTintado { get; set; }
        public ColoresTintado ColorTintado { get; set; }
        //-------------

        //relación con la tabla MaterialesCercos (1 Escandallo 1 Material cerco : 1 Material cerco N Escandallos)
        [ForeignKey("IdMaterialCerco")]
        public int IdMaterialCerco { get; set; }
        public MaterialesCercos MaterialCerco { get; set; }
        //-------------

        //relación con la tabla MaterialesPisos (1 Escandallo 1 Material piso : 1 Material piso N Escandallos)
        [ForeignKey("IdMaterialPiso")]
        public int IdMaterialPiso { get; set; }
        public MaterialesPisos MaterialPiso { get; set; }
        //-------------

        //relación con la tabla MaterialesTapas (1 Escandallo 1 Material tapas : 1 Material tapas N Escandallos)
        [ForeignKey("IdMaterialTapa")]
        public int IdMaterialTapa { get; set; }
        public MaterialesTapas MaterialTapa { get; set; }
        //-------------

        //relación con la tabla Trabajos (1 Escandallo 1 Trabajo : 1 Trabajo N Escandallos)               
        [ForeignKey("IdTrabajo")]
        public int IdTrabajo { get; set; }
        public Trabajos Trabajo { get; set; }
        //-------------

        //relación con la tabla Series (1 Escandallo 1 Serie : 1 Serie N Escandallos)               
        [ForeignKey("IdSerie")]
        public int IdSerie { get; set; }
        public Series Serie { get; set; }
        //-------------






        public string Pedido { get; set; } //relación con la tabla Pedidos (1 Escandallo N Pedidos : 1 Pedido N Escandallo)
        public string LineasSerie { get; set; } //relación con la tabla LineasSeries (1 Escandallo N LineasSerie : 1 LineaSerie N Escandallos)
    }
}

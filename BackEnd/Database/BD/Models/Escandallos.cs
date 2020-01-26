using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        

        public string Cliente { get; set; } //relación con la tabla Clientes (1 Escandallo 1 Cliente : 1 Cliente N Escandallos)
        public string Trabajo { get; set; } //relación con la tabla Trabajos (1 Escandallo 1 Trabajo : 1 Trabajo N Escandallos)
        public string MaterialPiso { get; set; } //relación con la tabla MaterialesPisos (1 Escandallo 1 Material piso : 1 Material piso N Escandallos)
        public string AlturaPiso { get; set; } //relación con la tabla AlturasPiso (1 Escandallo 1 AlturaPiso : 1 AlturaPiso N Escandallos) según la serie del cliente elegida
        public string ColorPiso { get; set; } //relación con la tabla ColorPiso (1 Escandallo 1 Color piso : 1 Color piso N Escandallos)
        public string MaterialTapa { get; set; } //relación con la tabla MaterialesTapas (1 Escandallo 1 Material tapas : 1 Material tapas N Escandallos)
        public string AlturaTapa { get; set; } //relación con la tabla AlturasTapa (1 Escandallo 1 AlturaTapa : 1 AlturaTapa N Escandallos) según la serie del cliente elegida
        public string ColorTapa { get; set; } //relación con la tabla ColorTapa (1 Escandallo 1 Color tapa : 1 Color tapa N Escandallos)
        public string MaterialCerco { get; set; } //relación con la tabla MaterialesCercos (1 Escandallo 1 Material cerco : 1 Material cerco N Escandallos)
        public string ColorCerco { get; set; } //relación con la tabla ColorCerco (1 Escandallo 1 Color Cerco : 1 Color cerco N Escandallos)
        public string Horma { get; set; } //relación con la tabla Hormas (1 Escandallo 1 Horma : 1 Horma N Escandallos)
        public string TroquelPiso { get; set; } //relación con la tabla Troqueles (1 Escandallo 1 Troquel : 1 Troquel N Escandallos)
        public string TroquelTapa { get; set; } //relación con la tabla Troqueles (1 Escandallo 1 Troquel : 1 Troquel N Escandallos)
        public string ColorTintado { get; set; } //relación con la tabla Hormas (1 Escandallo 1 Horma : 1 Horma N Escandallos)
        public string Serie { get; set; } //relación con la tabla Series (1 Escandallo 1 Serie : 1 Serie N Escandallos)
        public string LineasSerie { get; set; } //relación con la tabla LineasSeries (1 Escandallo N LineasSerie : 1 LineaSerie N Escandallos)
    }
}

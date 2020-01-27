using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Series
    {
        [Key]
        public int IdSerie { get; set; }
        public string Nombre { get; set; }        
        public int Precio { get; set; }
        public string Descripcion { get; set; }

        //RELACIONES
        //relación con la tabla Escandasllo (1 Serie N Escandallos : 1 Escandallos 1 Serie)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------


        public string LineasSerie { get; set; } //relación con la tabla lineasSerie (1 Serie N LineasSerie : 1 LineaSerie N Serie)
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class ColoresTintado
    {
        [Key]
        public string IdColorTintado { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }

        //RELACIONES
        //relación con la tabla Escandasllo (1 ColoresTintado N Escandallos : 1 Escandallos 1 ColoresTintado)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------      
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------
    }
}

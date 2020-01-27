using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class AlturasTapas
    {
        [Key]
        public string IdAlturaTapa { get; set; }
        public string Nombre { get; set; }
        public int Grosor { get; set; }
        public string Descripcion { get; set; }


        //RELACIONES
        //relación con la tabla Escandasllo (1 AlturasTapas N Escandallos : 1 Escandallos 1 AlturasTapas)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------




        public string MaterialTapa { get; set; } //relación con la tabla MaterialesTapas (1 AlturaTapas N MaterialesTapas : 1 MaterialTapa N AlturasTapa)                
    }
}

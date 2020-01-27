using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Trabajos
    {
        [Key]
        public int IdTrabajo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }               
        public int Precio { get; set; }

        //RELACIONES
        //relación con la tabla Escandallos (1 Trabajo N Escandallos : 1 Escandallo 1 Trabajo)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------        
        //relación con la tabla Pedidos (1 Trabajo N Pedidos : 1 Pedido 1 Trabajo)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------        
    }
}

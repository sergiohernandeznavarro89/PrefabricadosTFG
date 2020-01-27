using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Hormas
    {
        [Key]
        public int IdHorma { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }


        //RELACIONES        
        
        //relacion con tabla clientes (1 Horma 1 clientes : 1 cliente N Hormas)
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
        //-------------

        //relación con la tabla Escandallo (1 Horma N Escandallos : 1 Escandallo 1 Horma)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------




        public string Troquel { get; set; } //Relacion con tabla Troqueles (1 Horma N Troqueles : 1 Troquel N Hormas)               

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class TroquelesTapas
    {
        [Key]
        public int IdTroquelTapa { get; set; }
        public string Nombre { get; set; }


        //RELACIONES

        //relación con tabla Clientes (1 Troquel 0-1 cliente : 1 cliente 0-N Troqueles) indica si un troquel es genérico o de un cliente
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
        //---------------

        //relación con la tabla Escandallo (1 troquelTapas N Escandallos : 1 Escandallo 1 troquelTapas)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------


        public string Horma { get; set; } //Relacion con tabla Hormas (1 Troquel N Hormas : 1 Horma N Troqueles)

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class TroquelPiso
    {
        [Key]
        public int IdTroquelPiso { get; set; }
        public string Nombre { get; set; }


        #region RELACIONES
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        //---------------
        public ICollection<Escandallo> Escandallos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
        public ICollection<HormaTroquelPiso> HormasTroquelesPiso { get; set; }
        #endregion
    }
}

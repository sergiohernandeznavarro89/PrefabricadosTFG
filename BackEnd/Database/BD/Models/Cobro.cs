using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Cobro
    {
        [Key]
        public int IdCobro { get; set; }
        public DateTime FechaCobroPrevista { get; set; }
        public DateTime FechaRealizacionCobro { get; set; } //indica si se ha realizado el cobro o está pendiente de cobrar


        #region RELACIONES
        [ForeignKey("IdPedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        //-------------
        [ForeignKey("IdCliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        [ForeignKey("IdRemesa")]
        public int IdRemesa { get; set; }
        public Remesa Remesa { get; set; }
        //-------------
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFirma { get; set; }

        #region RELACIONES
        [ForeignKey("IdPedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        //-------------------------------
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class TrabajoPedido
    {
        [Key]
        public int IdTrabajoPedido { get; set; }

        #region RELACIONES   
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }     
        //-----------------------------------
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }        

        #endregion
    }
}

using Database.BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class TareaRealizadaDTO
    {
        [Key]
        public int IdTareaRealizada { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int HorasDedicadas { get; set; }
        public int ParesRealizados { get; set; }

        #region RELACIONES        
        public int? IdPedido { get; set; }
        public int? PedidoIdPedido { get; set; }
        public Pedido Pedido { get; set; }
        //-------------------------------
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        //-------------------------------
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }
        //-------------------------------
        public int? IdNomina { get; set; }
        public Nomina Nomina { get; set; }
        //-------------------------------
        #endregion
    }
}

using Database.BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class NominaDTO
    {
        [Key]
        public int IdNomina { get; set; }
        public float Importe { get; set; }

        #region RELACIONES                
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        //-------------------------------
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }
        //-------------------------------
        public ICollection<TareaRealizada> TareasRealizadas { get; set; }
        #endregion
    }
}

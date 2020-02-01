using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Remesa
    {
        [Key]
        public int IdRemesa { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String URLRemesa { get; set; }
        public DateTime FechaPresentacion { get; set; } //indica si la remesa se ha hecho efectiva, si ha sido envidada a la entidad bancaria

        #region RELACIONES
        public ICollection<Cobro> Cobros { get; set; }
        public ICollection<RemesaCliente> RemesasClientes { get; set; }
        #endregion
    }
}

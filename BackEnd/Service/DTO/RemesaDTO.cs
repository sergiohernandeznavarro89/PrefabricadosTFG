using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class RemesaDTO
    {
        public int IdRemesa { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String URLRemesa { get; set; }
        public DateTime FechaPresentacion { get; set; } //indica si la remesa se ha hecho efectiva, si ha sido envidada a la entidad bancaria

        #region RELACIONES
        public ICollection<CobroDTO> Cobros { get; set; }
        public ICollection<RemesaClienteDTO> RemesasClientes { get; set; }
        #endregion
    }
}

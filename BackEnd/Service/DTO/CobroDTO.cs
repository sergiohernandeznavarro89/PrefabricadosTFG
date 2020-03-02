using Service.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class CobroDTO
    {
        public int IdCobro { get; set; }
        public DateTime FechaCobroPrevista { get; set; }
        public DateTime FechaRealizacionCobro { get; set; } //indica si se ha realizado el cobro o está pendiente de cobrar


        #region RELACIONES
        public PedidoDTO Pedido { get; set; }
        //-------------
        public ClienteDTO Cliente { get; set; }
        //-------------
        public RemesaDTO Remesa { get; set; }
        //-------------
        #endregion
    }
}

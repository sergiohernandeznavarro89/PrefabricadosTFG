using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class AlbaranDTO
    {
        public int IdAlbaran { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFirma { get; set; }

        #region RELACIONES        
        public PedidoDTO Pedido { get; set; }
        //-------------------------------
        #endregion
    }
}

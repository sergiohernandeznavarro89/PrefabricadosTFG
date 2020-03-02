using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class TrabajoDTO
    {
        public int IdTrabajo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }               
        public int Precio { get; set; }

        #region RELACIONES        
        public ICollection<EscandalloDTO> Escandallos { get; set; }        
        public ICollection<PedidoDTO> Pedidos { get; set; }
        #endregion
    }
}

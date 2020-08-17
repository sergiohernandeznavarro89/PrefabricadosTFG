using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class TroquelPisoDTO
    {
        public int IdTroquelPiso { get; set; }
        public string Nombre { get; set; }

        #region RELACIONES
        public ClienteDTO Cliente { get; set; }
        //---------------
        public ICollection<EscandalloDTO> Escandallos { get; set; }
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<HormaTroquelPisoDTO> HormasTroquelesPiso { get; set; }
        #endregion
    }
}

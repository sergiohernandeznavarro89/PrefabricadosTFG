using Database.BD.Models;
using System;
using System.Collections.Generic;

namespace Service.DTO
{
    public class HormaDTO
    {
        public int IdHorma { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }


        #region RELACIONES
        public ClienteDTO Cliente { get; set; }
        public ICollection<EscandalloDTO> Escandallos { get; set; }
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<HormaTroquelPisoDTO> HormasTroquelesPiso { get; set; }
        public ICollection<HormaTroquelTapaDTO> HormasTroquelesTapa { get; set; }
        #endregion
    }
}

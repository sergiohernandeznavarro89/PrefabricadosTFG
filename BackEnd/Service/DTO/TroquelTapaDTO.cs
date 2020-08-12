using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Service.DTO
{
    public class TroquelTapaDTO
    {
        public int IdTroquelTapa { get; set; }
        public string Nombre { get; set; }


        #region RELACIONES
        public ClienteDTO Cliente { get; set; }
        //---------------
        public ICollection<EscandalloDTO> Escandallos { get; set; }
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<HormaTroquelTapaDTO> HormasTroquelesTapa { get; set; }
        #endregion        

    }
}

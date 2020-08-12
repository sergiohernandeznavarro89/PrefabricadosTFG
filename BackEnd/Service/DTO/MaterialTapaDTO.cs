using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class MaterialTapaDTO
    {
        public string IdMaterialTapa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        #region RELACIONES
        public ICollection<EscandalloDTO> Escandallos { get; set; }        
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<AlturaTapaMaterialTapaDTO> AlturasTapaMaterialesTapa { get; set; }
        public ICollection<ColorTapaMaterialTapaDTO> ColoresTapaMaterialesTapa { get; set; }
        #endregion        
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTO
{
    public class ColorCercoDTO
    {
        public string IdColorCerco { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }

        #region RELACIONES
        public ICollection<EscandalloDTO> Escandallos { get; set; }        
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<ColorCercoMaterialCercoDTO> ColoresCercoMaterialesCerco { get; set; }
        #endregion
        
    }
}

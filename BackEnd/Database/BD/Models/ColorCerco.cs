using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.BD.Models
{
    public class ColorCerco
    {
        [Key]
        public string IdColorCerco { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }


        #region RELACIONES
        public ICollection<Escandallo> Escandallos { get; set; }        
        public ICollection<Pedido> Pedidos { get; set; }
        public ICollection<ColorCercoMaterialCerco> ColoresCercoMaterialesCerco { get; set; }
        #endregion
        
    }
}

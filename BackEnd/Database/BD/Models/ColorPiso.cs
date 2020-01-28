using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class ColorPiso
    {
        [Key]
        public string IdColorPiso { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }



        #region RELACIONES
        public ICollection<Escandallo> Escandallos { get; set; }        
        public ICollection<Pedido> Pedidos { get; set; }
        public ICollection<ColorPisoMaterialPiso> ColoresPisoMaterialesPiso { get; set; }
        #endregion        
    }
}

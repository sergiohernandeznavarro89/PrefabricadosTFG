using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class MaterialPiso
    {
        [Key]
        public string IdMaterialPiso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        #region RELACIONES
        public ICollection<Escandallo> Escandallos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }        
        public ICollection<AlturaPisoMaterialPiso> AlturasPisoMaterialesPiso { get; set; }
        public ICollection<ColorPisoMaterialPiso> ColoresPisoMaterialesPiso { get; set; }
        #endregion
    }
}

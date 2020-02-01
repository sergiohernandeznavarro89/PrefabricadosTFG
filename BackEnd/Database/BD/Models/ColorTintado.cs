using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class ColorTintado
    {
        [Key]
        public string IdColorTintado { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }

        #region RELACIONES
        public ICollection<Escandallo> Escandallos { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
        #endregion
    }
}

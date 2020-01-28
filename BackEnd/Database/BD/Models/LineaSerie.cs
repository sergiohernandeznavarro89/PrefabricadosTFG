using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class LineaSerie
    {
        [Key]
        public int IdLineaSerie { get; set; }
        public string Nombre { get; set; }
        public int NumeroDesde { get; set; }                
        public int NumeroHasta { get; set; }

        #region RELACIONES
        public ICollection<LineaSerieSerie> LineasSerieSeries { get; set; }
        public ICollection<LineaSeriePedido> LineasSeriePedidos { get; set; }
        public ICollection<LineaSerieEscandallo> LineasSerieEscandallos { get; set; }
        #endregion
    }
}

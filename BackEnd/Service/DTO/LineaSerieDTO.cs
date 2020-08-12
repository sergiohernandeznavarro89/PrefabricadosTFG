using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class LineaSerieDTO
    {
        public int IdLineaSerie { get; set; }
        public string Nombre { get; set; }
        public int NumeroDesde { get; set; }                
        public int NumeroHasta { get; set; }

        #region RELACIONES
        public ICollection<LineaSerieSerieDTO> LineasSerieSeries { get; set; }
        public ICollection<LineaSeriePedidoDTO> LineasSeriePedidos { get; set; }
        public ICollection<LineaSerieEscandalloDTO> LineasSerieEscandallos { get; set; }
        #endregion
    }
}

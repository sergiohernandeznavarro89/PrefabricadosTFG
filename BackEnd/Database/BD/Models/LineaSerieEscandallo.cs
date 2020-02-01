using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class LineaSerieEscandallo
    {
        public int LineaSerieId { get; set; }
        public LineaSerie LineaSerie { get; set; }

        public int EscandalloId { get; set; }
        public Escandallo Escandallo { get; set; }        
    }
}

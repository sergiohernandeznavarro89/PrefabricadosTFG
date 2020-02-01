using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class LineaSerieSerie
    {
        public int LineaSerieId { get; set; }
        public LineaSerie LineaSerie{ get; set; }

        public int SerieId { get; set; }
        public Serie Serie { get; set; }
    }
}

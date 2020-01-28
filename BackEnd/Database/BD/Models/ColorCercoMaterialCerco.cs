using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class ColorCercoMaterialCerco
    {
        public int MaterialCercoId { get; set; }
        public MaterialCerco MaterialCerco { get; set; }

        public int ColorCercoId { get; set; }
        public ColorCerco ColorCero { get; set; }
    }
}

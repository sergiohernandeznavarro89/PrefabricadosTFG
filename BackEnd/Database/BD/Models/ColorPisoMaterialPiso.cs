using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class ColorPisoMaterialPiso
    {
        public int ColorPisoId { get; set; }
        public ColorPiso ColorPiso { get; set; }

        public int MaterialPisoId { get; set; }
        public MaterialPiso MaterialPiso { get; set; }
    }
}

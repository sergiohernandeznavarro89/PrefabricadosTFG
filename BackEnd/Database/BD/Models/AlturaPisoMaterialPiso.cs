using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class AlturaPisoMaterialPiso
    {
        public int AlturaPisoId { get; set; }
        public AlturaPiso AlturaPiso { get; set; }

        public int MaterialPisoId { get; set; }
        public MaterialPiso MaterialPiso { get; set; }
    }
}

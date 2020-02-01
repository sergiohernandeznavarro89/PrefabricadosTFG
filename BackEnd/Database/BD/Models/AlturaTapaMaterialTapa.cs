using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class AlturaTapaMaterialTapa
    {
        public int AlturaTapaId { get; set; }
        public AlturaTapa AlturaTapa { get; set; }

        public int MaterialTapaId { get; set; }
        public MaterialTapa MaterialTapa { get; set; }
    }
}

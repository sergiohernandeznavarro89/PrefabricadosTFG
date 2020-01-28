using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class ColorTapaMaterialTapa
    {
        public int ColorTapaId { get; set; }
        public ColorTapa ColorTapa { get; set; }

        public int MaterialTapaId { get; set; }
        public MaterialTapa MaterialTapa { get; set; }
    }
}

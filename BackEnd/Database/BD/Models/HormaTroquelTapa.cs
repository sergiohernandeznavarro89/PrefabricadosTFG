using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class HormaTroquelTapa
    {
        public int HormaId { get; set; }
        public Horma Horma { get; set; }

        public int TroquelTapaId { get; set; }
        public TroquelTapa TroquelTapa { get; set; }
    }
}

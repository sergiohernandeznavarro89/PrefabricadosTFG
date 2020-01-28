using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class HormaTroquelPiso
    {
        public int HormaId { get; set; }
        public Horma Horma { get; set; }

        public int TroquelPisoId { get; set; }
        public TroquelPiso TroquelPiso { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class RemesaCliente
    {
        public int RemesaId { get; set; }
        public Remesa Remesa { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }        
    }
}

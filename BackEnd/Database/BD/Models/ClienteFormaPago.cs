using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class ClienteFormaPago
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int FormaPagoId { get; set; }
        public FormaPago FormaPago { get; set; }
    }
}

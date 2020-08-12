using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class ClienteFormaPagoDTO
    {
        public ClienteDTO Cliente { get; set; }

        public FormaPagoDTO FormaPago { get; set; }
    }
}

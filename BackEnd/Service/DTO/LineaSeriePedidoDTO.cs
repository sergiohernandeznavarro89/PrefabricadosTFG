using System;
using System.Collections.Generic;
using System.Text;

namespace Service.DTO
{
    public class LineaSeriePedidoDTO
    {
        public LineaSerieDTO LineaSerie { get; set; }

        public PedidoDTO Pedido { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class LineaSeriePedido
    {
        public int LineaSerieId { get; set; }
        public LineaSerie LineaSerie { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}

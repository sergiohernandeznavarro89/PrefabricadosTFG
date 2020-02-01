using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Models
{
    public class EscandalloPedido
    {
        public int EscandalloId { get; set; }
        public Escandallo Escandallo { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}

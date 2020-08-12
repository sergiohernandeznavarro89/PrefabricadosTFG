using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.DTO
{
    public class FormaPagoDTO
    {
        public int IdFormaPago { get; set; }
        public string Nombre { get; set; }
        public int NumeroPagos { get; set; } //en cuantos pagos se fracciona el importe total
        public int giro { get; set; } //cada cuanto tiempo se realiza el pago (cada 30, 60, 90, 120 días)
        public string descripcion { get; set; } //Información sobre el tipo de pago 


        #region RELACIONES
        public ICollection<PedidoDTO> Pedidos { get; set; }
        public ICollection<ClienteFormaPagoDTO> ClientesFormasPago { get; set; }
        #endregion
    }
}

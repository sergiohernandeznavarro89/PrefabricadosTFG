using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class FormasPago
    {
        [Key]
        public int IdFormaPago { get; set; }
        public string Nombre { get; set; }
        public int NumeroPagos { get; set; } //en cuantos pagos se fracciona el importe total
        public int giro { get; set; } //cada cuanto tiempo se realiza el pago (cada 30, 60, 90, 120 días)
        public string descripcion { get; set; } //Información sobre el tipo de pago 




        public string Cliente { get; set; } //relacion con tabla clientes (1 forma de pago N clientes : 1 cliente 1 forma de pago)
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; } //HermanosInd&antPrefabricados S.L.
        public string NombreComercial { get; set; } //inprean
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Poblacion { get; set; }
        public string Direccion { get; set; }
        public int CodPostal { get; set; }
        public string DNI { get; set; }
        public string CIF { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Correo { get; set; }
        public string IBAN { get; set; }
        public DateTime VencimientoFijo { get; set; } //Fecha fija de cobros de pedidos        
        public int Subida { get; set; } //Porcentaje de subida de precios que se aplica al cliente
        public int Descuento { get; set; } //Porcentaje de descuento de precios que se aplica al cliente



        #region RELACIONES
        public ICollection<Horma> Hormas { get; set; }        
        public ICollection<TroquelTapa> TroquelesTapaPropios { get; set; }
        public ICollection<Escandallo> Escandallos { get; set; }
        public ICollection<ClienteFormaPago> ClientesFormasPago { get; set; }
        public ICollection<RemesaCliente> RemesasClientes { get; set; }
        public ICollection<Cobro> Cobros { get; set; }
        #endregion
    }
}




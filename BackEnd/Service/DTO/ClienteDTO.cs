using Database.BD.Models;
using System;
using System.Collections.Generic;

namespace Service.DTO
{
    public class ClienteDTO
    {
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
        //public List<HormaDTO> Hormas { get; set; }
        //public List<TroquelTapaDTO> TroquelesTapaPropios { get; set; }
        //public List<EscandalloDTO> Escandallos { get; set; }
        //public List<ClienteFormaPagoDTO> ClientesFormasPago { get; set; }
        //public List<RemesaClienteDTO> RemesasClientes { get; set; }
        //public List<CobroDTO> Cobros { get; set; }
        //public List<PedidoDTO> Pedidos { get; set; }

        #endregion
    }
}

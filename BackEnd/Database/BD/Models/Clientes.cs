using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Clientes
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

        //RELACIONES
        //Relacion con tabla Hormas (1 cliente N hormas : 1 horma 1 cliente)        
        public ICollection<Hormas> Hormas { get; set; }
        //-----------------
        
        //Relacion con tabla Troqueles (1 cliente 0-N Troqueles propios : 1 Troquel 0-1 cliente)        
        public ICollection<TroquelesPisos> TroquelesPisosPropios { get; set; }
        public ICollection<TroquelesTapas> TroquelesTapasPropios { get; set; }
        //------------------

        //relación con la tabla Escandallo (1 Cliente N Escandallos : 1 Escandallo 1 Cliente)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------






        public string FormaPago { get; set; } //Relacion con tabla formas de pago (1 cliente N forma de pago : 1 forma de pago N clientes)                        



    }
}




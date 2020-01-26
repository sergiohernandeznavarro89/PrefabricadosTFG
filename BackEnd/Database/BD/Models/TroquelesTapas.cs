using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class TroquelesTapas
    {
        [Key]
        public int IdTroquelTapa { get; set; }
        public string Nombre { get; set; }        





        public string Cliente { get; set; } //relación con tabla Clientes (1 Troquel 0-1 cliente : 1 cliente 0-N Troqueles) indica si un troquel es genérico o de un cliente
        public string Horma { get; set; } //Relacion con tabla Hormas (1 Troquel N Hormas : 1 Horma N Troqueles)
        public string Escandallo { get; set; } //relación con la tabla Escandallo (1 Troquel N Escandallos : 1 Escandallo 1 Troquel)

    }
}

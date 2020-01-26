using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    class Hormas
    {
        [Key]
        public int IdHorma { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }




        public string Troquel { get; set; } //Relacion con tabla Troqueles (1 Horma N Troqueles : 1 Troquel N Hormas)
        public string Cliente { get; set; } //relacion con tabla clientes (1 Horma 1 clientes : 1 cliente N Hormas)
        public string Escandallo { get; set; } //relación con la tabla Escandallo (1 Horma N Escandallos : 1 Escandallo 1 Horma)

    }
}

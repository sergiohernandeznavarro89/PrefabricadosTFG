using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class AlturasTapas
    {
        [Key]
        public string IdAlturaTapa { get; set; }
        public string Nombre { get; set; }
        public int Grosor { get; set; }
        public string Descripcion { get; set; }




        public string MaterialTapa { get; set; } //relación con la tabla MaterialesTapas (1 AlturaTapas N MaterialesTapas : 1 MaterialTapa N AlturasTapa)        
        public string Escandallo { get; set; } //relación con la tabla Escandasllo (1 AlturasTapas N Escandallos : 1 Escandallos 1 AlturasTapas)
    }
}

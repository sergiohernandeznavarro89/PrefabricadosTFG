using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class MaterialesCercos
    {
        [Key]
        public string IdMaterialCerco { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        public string ColorCerco { get; set; } //relación con la tabla ColorCercos (1 MaterialCerco N ColoresCerco : 1 ColorCerco N MaterialesCercos)
        public string Escandallo { get; set; } //relación con la tabla Escandasllo (1 MaterialesCercos N Escandallos : 1 Escandallos 1 MaterialesCercos)
    }
}

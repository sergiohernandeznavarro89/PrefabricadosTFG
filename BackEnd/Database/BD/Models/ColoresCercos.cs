using System.ComponentModel.DataAnnotations;

namespace Database.BD.Models
{
    public class ColoresCercos
    {
        [Key]
        public string IdColorCerco { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }




        public string MaterialCerco { get; set; } //relación con la tabla MaterialesCercos (1 ColorCerco N MaterialesCercos : 1 MaterialCerco N ColoresCerco)
        public string Escandallo { get; set; } //relación con la tabla Escandasllo (1 ColorCerco N Escandallos : 1 Escandallos 1 ColorCerco)
    }
}

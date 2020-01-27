using System.Collections.Generic;
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


        //RELACIONES
        //relación con la tabla Escandasllo (1 ColorCerco N Escandallos : 1 Escandallos 1 ColorCerco)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------




        public string MaterialCerco { get; set; } //relación con la tabla MaterialesCercos (1 ColorCerco N MaterialesCercos : 1 MaterialCerco N ColoresCerco)
    }
}

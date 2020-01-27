using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class MaterialesTapas
    {
        [Key]
        public string IdMaterialTapa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //RELACIONES
        //relación con la tabla Escandasllo (1 MaterialesTapas N Escandallos : 1 Escandallos 1 MaterialesTapas)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------







        public string AlturaTapa { get; set; } //relación con la tabla AlturaTapa (1 MaterialesTapas N AlturaTapa : 1 AlturaTapa N MaterialesTapas)
        public string ColorTapa { get; set; } //relación con la tabla ColorTapa (1 MaterialesTapas N ColorTapa : 1 ColorTapa N MaterialesTapas)        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class AlturasPisos
    {
        [Key]
        public string IdAlturaPiso { get; set; }
        public string Nombre { get; set; }
        public int Grosor { get; set; }
        public string Descripcion { get; set; }


        //RELACIONES
        //relación con la tabla Escandallo (1 AlturasPisos N Escandallos : 1 Escandallos 1 AlturasPisos)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        //relación con la tabla Pedidos (1 AlturasPisos N Pedidos : 1 Pedido 1 AlturasPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------




        public string MaterialPiso { get; set; } //relación con la tabla MaterialesPisos (1 AlturaPisos N MaterialesPisos : 1 MaterialPiso N AlturasPisos)        
    }
}

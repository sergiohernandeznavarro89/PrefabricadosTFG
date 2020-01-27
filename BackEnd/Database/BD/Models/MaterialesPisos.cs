using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class MaterialesPisos
    {
        [Key]
        public string IdMaterialPiso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //RELACIONES
        //relación con la tabla Escandallo (1 MaterialesPisos N Escandallos : 1 Escandallos 1 MaterialesPisos)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------

        //relación con la tabla Pedidos (1 Material piso N Pedidos : 1 Pedido 1 Material piso)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------





        public string AlturaPiso { get; set; } //relación con la tabla AlturaPisos (1 MaterialPiso N AlturasPisos : 1 AlturaPisos N MaterialesPisos)
        public string ColorPiso { get; set; } //relación con la tabla ColorPisos (1 MaterialPiso N ColorPiso : 1 ColorPiso N MaterialesPisos)
    }
}

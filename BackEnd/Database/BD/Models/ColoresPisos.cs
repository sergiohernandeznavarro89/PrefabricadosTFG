﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class ColoresPisos
    {
        [Key]
        public string IdColorPiso { get; set; }
        public string Nombre { get; set; }
        public int RGB { get; set; }
        public string Descripcion { get; set; }

        //RELACIONES
        //relación con la tabla Escandasllo (1 ColoresPisos N Escandallos : 1 Escandallos 1 ColoresPisos)
        public ICollection<Escandallos> Escandallos { get; set; }
        //------------------
        
        //relación con la tabla Pedido (1 ColoresPisos N Pedidos : 1 Pedidos 1 ColoresPisos)
        public ICollection<Pedidos> Pedidos { get; set; }
        //------------------





        public string MaterialPiso { get; set; } //relación con la tabla MaterialesPisos (1 AlturaPisos N MaterialesPisos : 1 MaterialPiso N AlturasPisos)        
    }
}

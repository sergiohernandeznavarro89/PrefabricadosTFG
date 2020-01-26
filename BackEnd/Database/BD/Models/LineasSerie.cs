using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class LineasSerie
    {
        [Key]
        public int IdLineaSerie { get; set; }
        public string Nombre { get; set; }
        public int NumeroDesde { get; set; }                
        public int NumeroHasta { get; set; }



        public string Serie { get; set; } //relación con la tabla Series (1 LineaSerie 1 Serie : 1 Serie N LineasSerie)
    }
}

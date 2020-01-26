using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.BD.Models
{
    public class Series
    {
        [Key]
        public int IdSerie { get; set; }
        public string Nombre { get; set; }        
        public int Precio { get; set; }
        public string Descripcion { get; set; }


        public string LineasSerie { get; set; } //relación con la tabla lineasSerie (1 Serie N LineasSerie : 1 LineaSerie 1 Serie)
    }
}

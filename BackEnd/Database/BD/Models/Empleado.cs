using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database.BD.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nif { get; set; }
        public string Email { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string CodPostal { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int IBAN { get; set; }        

        #region RELACIONES        
        //-------------------------------
        public ICollection<Nomina> Nominas { get; set; }
        public ICollection<TareaRealizada> TareasRealizadas { get; set; }
        #endregion
    }
}

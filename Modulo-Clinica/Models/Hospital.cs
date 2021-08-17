using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Hospital 
    {
        [Key]
        public int HospitalId { get; set; }
        public string RNC { get; set; }
        public int Habitaciones { get; set; }
        public DateTime Horario { get; set; }
        public int Cantidad_Empleados { get; set; }
        public int Cantidad_Pacientes { get; set; }

    }
}

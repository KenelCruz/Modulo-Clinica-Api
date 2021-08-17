using Modulo_Clinica.Enums;
using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Enfermedad 
    {
        public Enfermedad()
        {
            Padecimiento = new HashSet<Padecimiento>();
        }
        [Key]
        public int EnfermedadId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Sintomas { get; set; }
        public Peligrosidad Nivel_Peligro { get; set; }


        public virtual ICollection<Padecimiento> Padecimiento { get; set; }


    }
}

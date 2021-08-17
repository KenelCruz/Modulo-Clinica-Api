using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Farmacia 
    {
        [Key]
        public int FarmaciaId { get; set; }
        public int? MedicamentosId { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public int? PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}

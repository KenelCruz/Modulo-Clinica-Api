using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Padecimiento
    {
        [Key]
        public int PadecimientoId { get; set; }
        public virtual Paciente Paciente { get; set; }
        public int PaccienteId { get; set; }
        public virtual Enfermedad Enfermedad { get; set; }
        public int EnfermedadId { get; set; }

    }
}

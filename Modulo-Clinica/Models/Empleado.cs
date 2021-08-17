using Modulo_Clinica.Enums;
using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Empleado 
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Rol Cargo { get; set; }

        public int UsuarioId { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}

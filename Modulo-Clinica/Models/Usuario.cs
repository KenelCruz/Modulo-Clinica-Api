using Modulo_Clinica.Enums;
using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Usuario 
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public Rol Tipo_usuario { get; set; }

        public int EmpleadoId { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}

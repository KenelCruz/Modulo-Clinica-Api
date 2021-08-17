using Modulo_Clinica.Enums;
using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Paciente 
    {
        public Paciente()
        {
            Farmacia = new HashSet<Farmacia>();
            Padecimento = new HashSet<Padecimiento>();
        }
        [Key]
        public int PaccienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tipo_Documento Tipo_Documento { get; set; }
        public string Valor_Tipo_Contenido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string MotivoConsulta { get; set; }
        public bool Alta { get; set; }


        public virtual ICollection<Farmacia> Farmacia { get; set; }
        public virtual ICollection<Padecimiento> Padecimento { get; set; }

        public int? HistorialId { get; set; }
        public virtual ICollection<HistorialMedico> Historial { get; set; }


    }
}

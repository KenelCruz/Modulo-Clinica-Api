using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class Medicamento 
    {
        public Medicamento()
        {

            Farmacia = new HashSet<Farmacia>();
        }
        [Key]
        public int MedicamentosId { get; set; }
        public int PacientesId { get; set; }
        public string Nombre { get; set; }
        public int Canitdad { get; set; } //Por Cajas
        public string Tipo { get; set; }
        public string Laboratiorio { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public virtual ICollection<Farmacia> Farmacia { get; set; }
    }
}

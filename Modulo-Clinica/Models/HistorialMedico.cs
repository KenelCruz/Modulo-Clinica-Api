using Modulo_Clinica.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class HistorialMedico 
    {
        [Key]
        public int HistorialId { get; set; }
        public string Enfermedades_infantiles { get; set; }
        public string Secuelas_infanteles { get; set; }
        public string Enfermedades_adolecencia { get; set; }
        public string Secuelas_adolecencia { get; set; }
        public string Enfermedades_Adultez { get; set; }
        public string Secuelas_Adultez { get; set; }

        public bool Hospitalizaciones { get; set; }
        public bool AntecedentesQx { get; set; }
        public bool Transfuciones { get; set; }
        public bool Fracturas { get; set; }
        public bool ETS { get; set; }
        public bool Alergicos { get; set; }
        public string Espesificacion_alergica { get; set; }


        #region Vacunas
        public bool Tetano { get; set; }
        public bool Difeeria { get; set; }
        public bool Sarampion { get; set; }
        public bool Gripe { get; set; }
        public bool Influenza { get; set; }
        public bool Herpes { get; set; }
        public string Otros { get; set; }
        #endregion

        #region Relaciones
        public int PacienteeId { get; set; }
        public virtual Paciente Paciente { get; set; }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.ModelBase
{
    public interface IBaseEntity : IBase
    {
        DateTimeOffset? EliminarFecha { get; set; }
        DateTimeOffset CrearFecha { get; set; }
        DateTimeOffset? ActualizarFecha { get; set; }
        string CreadoPor { get; set; }
        string EliminadoPor { get; set; }
        string ActualizadoPor { get; set; }
    }
    public class BaseEntity : Base, IBaseEntity
    {
        public virtual DateTimeOffset? EliminarFecha { get; set; }
        public virtual DateTimeOffset CrearFecha { get; set; }
        public virtual DateTimeOffset? ActualizarFecha { get; set; }
        public virtual string CreadoPor { get; set; }
        public virtual string EliminadoPor { get; set; }
        public virtual string ActualizadoPor { get; set; }
    }

}

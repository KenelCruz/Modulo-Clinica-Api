using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.ModelBase
{
    public interface IBase
    {
        int Id { get; set; }
        bool Eliminado { get; set; }
    }
    public class Base : IBase
    {
        public virtual int Id { get; set; }
        public virtual bool Eliminado { get; set; }
    }
}

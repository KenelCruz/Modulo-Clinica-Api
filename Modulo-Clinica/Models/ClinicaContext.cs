using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_Clinica.Models
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options)
           : base(options)
        {
        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }
        public DbSet<HistorialMedico> HistorialMedicos { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Farmacia> Farmacias { get; set; }
        public DbSet<Padecimiento> Padecimientos { get; set; }
    }
}

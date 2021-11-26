using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoHospital.Models;

namespace ProyectoHospital.Context
{
    public class HospitalDatabaseContext : DbContext
    {
        public
HospitalDatabaseContext(DbContextOptions<HospitalDatabaseContext> options)
: base(options)
        {
        }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Abonado> Abonado { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Fecha> Fecha { get; set; }
        public DbSet<ProyectoHospital.Models.Fecha> Fecha_1 { get; set; }
        public DbSet<ProyectoHospital.Models.Turno> Turno_1 { get; set; }


    }

}


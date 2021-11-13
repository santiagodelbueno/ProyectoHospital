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

    }

}


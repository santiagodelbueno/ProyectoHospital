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
        public HospitalDatabaseContext(DbContextOptions<HospitalDatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurnoMedico>().HasKey(sc => new { sc.MedicoId, sc.TurnoId });
        }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<ProyectoHospital.Models.TurnoMedico> TurnoMedico { get; set; }


    }

}


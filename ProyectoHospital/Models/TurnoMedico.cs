using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHospital.Models
{
    public class TurnoMedico
    {
        [Required]
        [Display(Name = "Medico")]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        [Required]
        [Display(Name = "Turno")]
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }
    }
}

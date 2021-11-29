using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHospital.Models
{
    public class Turno
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "El campo Fecha del Turno es requerido")]
        [Display(Name = "Fecha del Turno")]
        public DateTime Fecha { get; set; }

        public List<TurnoMedico> TurnoMedico { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoHospital.Models
{
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }


        [Required]
        [Display(Name = "Especialidad")]
        [EnumDataType(typeof(Especialidad))]
        public Especialidad Especialidad { get; set; }


        [Required]
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<TurnoMedico> TurnoMedico { get; set; }




    }
}
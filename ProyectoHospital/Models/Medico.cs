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
        public string Nombre { get; set; }
        public int Edad { get; set; }
        [EnumDataType(typeof(Especialidad))]
        public Especialidad EspecialidadFavorita { get; set; }
    

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoHospital.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Sólo se permiten letras en el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Mail es requerido")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "El campo NroAfiliado es requerido")]
        public int NroAfiliado { get; set; }

        public Turno Turno { get; set; }

    }
}

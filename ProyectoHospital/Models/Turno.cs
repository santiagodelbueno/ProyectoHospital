﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoHospital.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public string hora { get; set; }
        public int idMedico { get; set; }
    }
}

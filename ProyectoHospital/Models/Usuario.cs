﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoHospital.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
    }
}

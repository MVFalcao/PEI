﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EditoraAPI.Models
{
    public class Tipo
    {
        [Key] public int ID_Tipo { get; set; }
        [Required] [StringLength(50)] public string Descricao { get; set; }
    }
}
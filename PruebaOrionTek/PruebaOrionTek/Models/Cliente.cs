﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaOrionTek.Models
{
    public class Cliente
    {
        [PrimaryKey,AutoIncrement]
        public int Id {get;set;}
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        [StringLength(int.MaxValue)]
        public string Direccion { get; set; }
        public int IdEmpresa { get; set; }  
    }
}

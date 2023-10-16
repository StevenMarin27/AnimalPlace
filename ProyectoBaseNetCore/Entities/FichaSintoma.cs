﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBaseNetCore.Entities
{
    public class FichaSintoma : CrudEntities
    {
        [Key]
        public long IdFicha { get; set; }
        public long? IdMascotas { get; set; }
        public Mascotas Mascotas { get; set; }
        public string SvrdadSntmas { get; set; }
        public long? IdResultado { get; set; }
        public Resultado Resultado { get; set; }     
        public long? IdUser { get; set; }
        public User User { get; set; }

        public List<Detalle> Detalles { get; set; }
    }
}
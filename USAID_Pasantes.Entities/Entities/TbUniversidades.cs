﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbUniversidades
    {
        public tbUniversidades()
        {
            tbRegionales = new HashSet<tbRegionales>();
        }

        public int univ_Id { get; set; }
        public string univ_DescripcionUniversidad { get; set; }
        public string univ_Abreviatura { get; set; }
        public int? univ_UsuarioCreacion { get; set; }
        public DateTime? univ_FechaCreacion { get; set; }
        public int? univ_UsuarioModificacion { get; set; }
        public DateTime? univ_FechaModificacion { get; set; }
        public bool? univ_Estado { get; set; }

        public virtual tbUsuarios univ_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios univ_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRegionales> tbRegionales { get; set; }
    }
}
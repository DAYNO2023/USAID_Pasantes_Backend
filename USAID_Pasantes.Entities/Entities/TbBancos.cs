﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbBancos
    {
        public tbBancos()
        {
            tbOptantes = new HashSet<tbOptantes>();
        }

        public int banc_Id { get; set; }
        public string banc_Descripcion { get; set; }
        public int? banc_UsuarioCreacion { get; set; }
        public DateTime? banc_FechaCreacion { get; set; }
        public int? banc_UsuarioModificacion { get; set; }
        public DateTime? banc_FechaModificacion { get; set; }
        public bool? banc_Estado { get; set; }

        public virtual tbUsuarios banc_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios banc_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOptantes> tbOptantes { get; set; }
    }
}
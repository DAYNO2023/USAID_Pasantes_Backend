﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbModulos
    {
        public tbModulos()
        {
            tbModulosPorRoles = new HashSet<tbModulosPorRoles>();
        }

        public int modu_Id { get; set; }
        public string modu_DescripcionModulo { get; set; }
        public string modu_UrlModulo { get; set; }
        public int? modu_UsuarioCreacion { get; set; }
        public DateTime? modu_FechaCreacion { get; set; }
        public int? modu_UsuarioModificacion { get; set; }
        public DateTime? modu_FechaModificacion { get; set; }
        public bool? modu_Estado { get; set; }

        public virtual tbUsuarios modu_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios modu_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbModulosPorRoles> tbModulosPorRoles { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbDocumentosOptantes
    {
        public int doop_Id { get; set; }
        public int tido_Id { get; set; }
        public string doop_Descripcion { get; set; }
        public int? doop_UsuarioCreacion { get; set; }
        public DateTime? doop_FechaCreacion { get; set; }
        public int? doop_UsuarioModificacion { get; set; }
        public DateTime? doop_FechaModificacion { get; set; }
        public bool? doop_Estado { get; set; }
        public int opta_Id { get; set; }

        public virtual tbUsuarios doop_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios doop_UsuarioModificacionNavigation { get; set; }
        public virtual tbOptantes opta { get; set; }
        public virtual tbTipoDocumento tido { get; set; }
    }
}
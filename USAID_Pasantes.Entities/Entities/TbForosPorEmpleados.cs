﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbForosPorEmpleados
    {
        public int foem_Id { get; set; }
        public int foro_Id { get; set; }
        public string foem_Descripcion { get; set; }
        public bool foem_ForoProgramado { get; set; }
        public DateTime? foem_FechaHoraProgramado { get; set; }
        public int? foem_UsuarioCreacion { get; set; }
        public DateTime? foem_FechaCreacion { get; set; }
        public int? foem_UsuarioModificacion { get; set; }
        public DateTime? foem_FechaModificacion { get; set; }
        public bool? foem_Estado { get; set; }

        public virtual tbUsuarios foem_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios foem_UsuarioModificacionNavigation { get; set; }
        public virtual tbForos foro { get; set; }
    }
}
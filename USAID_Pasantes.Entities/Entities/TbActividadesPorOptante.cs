﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbActividadesPorOptante", Schema = "Gest")]
    public partial class tbActividadesPorOptante
    {
        [Key]
        public int acpe_Id { get; set; }
        public int acti_Id { get; set; }
        public int opta_Id { get; set; }
        public int? acpe_HorasCumplidas { get; set; }
        [StringLength(200)]
        public string acpe_Observacion { get; set; }
        public int? acpe_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? acpe_FechaCreacion { get; set; }
        public int? acpe_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? acpe_FechaModificacion { get; set; }
        public bool? acpe_Estado { get; set; }

        [ForeignKey(nameof(acpe_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbActividadesPorOptanteacpe_UsuarioCreacionNavigation))]
        public virtual tbUsuarios acpe_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(acpe_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbActividadesPorOptanteacpe_UsuarioModificacionNavigation))]
        public virtual tbUsuarios acpe_UsuarioModificacionNavigation { get; set; }
        [ForeignKey(nameof(acti_Id))]
        [InverseProperty(nameof(tbActividades.tbActividadesPorOptante))]
        public virtual tbActividades acti { get; set; }
        [ForeignKey(nameof(opta_Id))]
        [InverseProperty(nameof(tbOptantes.tbActividadesPorOptante))]
        public virtual tbOptantes opta { get; set; }
    }
}
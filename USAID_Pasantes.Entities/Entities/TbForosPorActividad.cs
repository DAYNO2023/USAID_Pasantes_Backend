﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbForosPorActividad", Schema = "Comn")]
    public partial class tbForosPorActividad
    {
        [Key]
        public int foac_Id { get; set; }
        public int foro_Id { get; set; }
        public int? acti_Id { get; set; }
        public int? comp_Id { get; set; }
        public bool foac_ForoProgramado { get; set; }
        public bool? foac_OtorgaHoras { get; set; }
        [Required]
        public string foac_Descripcion { get; set; }
        public TimeSpan? foac_Horas { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foac_FechaHoraProgramado { get; set; }
        public int? foac_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foac_FechaCreacion { get; set; }
        public int? foac_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foac_FechaModificacion { get; set; }
        public bool? foac_Estado { get; set; }

        [ForeignKey(nameof(acti_Id))]
        [InverseProperty(nameof(tbActividades.tbForosPorActividad))]
        public virtual tbActividades acti { get; set; }
        [ForeignKey(nameof(comp_Id))]
        [InverseProperty(nameof(tbComponentes.tbForosPorActividad))]
        public virtual tbComponentes comp { get; set; }
        [ForeignKey(nameof(foac_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbForosPorActividadfoac_UsuarioCreacionNavigation))]
        public virtual tbUsuarios foac_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(foac_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbForosPorActividadfoac_UsuarioModificacionNavigation))]
        public virtual tbUsuarios foac_UsuarioModificacionNavigation { get; set; }
        [ForeignKey(nameof(foro_Id))]
        [InverseProperty(nameof(tbForos.tbForosPorActividad))]
        public virtual tbForos foro { get; set; }
    }
}
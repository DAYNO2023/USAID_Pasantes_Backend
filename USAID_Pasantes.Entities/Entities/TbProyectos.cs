﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbProyectos", Schema = "Gest")]
    [Index(nameof(pryt_DescripcionProyecto), Name = "UQ__tbProyec__7ECE41F76EDD43EA", IsUnique = true)]
    public partial class tbProyectos
    {
        public tbProyectos()
        {
            tbComponentes = new HashSet<tbComponentes>();
        }

        [Key]
        public int pryt_Id { get; set; }
        [Required]
        [StringLength(60)]
        public string pryt_DescripcionProyecto { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? pryt_HorasProceso { get; set; }
        public int empr_Id { get; set; }
        public int? pryt_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? pryt_FechaCreacion { get; set; }
        public int? pryt_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? pryt_FechaModificacion { get; set; }
        public bool? pryt_Estado { get; set; }

        [ForeignKey(nameof(empr_Id))]
        [InverseProperty(nameof(tbEmpresas.tbProyectos))]
        public virtual tbEmpresas empr { get; set; }
        [ForeignKey(nameof(pryt_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbProyectospryt_UsuarioCreacionNavigation))]
        public virtual tbUsuarios pryt_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(pryt_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbProyectospryt_UsuarioModificacionNavigation))]
        public virtual tbUsuarios pryt_UsuarioModificacionNavigation { get; set; }
        [InverseProperty("pryt")]
        public virtual ICollection<tbComponentes> tbComponentes { get; set; }
    }
}
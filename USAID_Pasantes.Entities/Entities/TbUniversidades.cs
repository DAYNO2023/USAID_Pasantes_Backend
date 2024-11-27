﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbUniversidades", Schema = "Gral")]
    [Index(nameof(univ_DescripcionUniversidad), Name = "UQ__tbUniver__5983CA8A334C9D0D", IsUnique = true)]
    [Index(nameof(univ_Abreviatura), Name = "UQ__tbUniver__C90F8EAAB2A7DB44", IsUnique = true)]
    public partial class tbUniversidades
    {
        public tbUniversidades()
        {
            tbRegionales = new HashSet<tbRegionales>();
        }

        [Key]
        public int univ_Id { get; set; }
        [Required]
        [StringLength(100)]
        public string univ_DescripcionUniversidad { get; set; }
        [StringLength(5)]
        public string univ_Abreviatura { get; set; }
        public int? univ_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? univ_FechaCreacion { get; set; }
        public int? univ_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? univ_FechaModificacion { get; set; }
        public bool? univ_Estado { get; set; }

        [ForeignKey(nameof(univ_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbUniversidadesuniv_UsuarioCreacionNavigation))]
        public virtual tbUsuarios univ_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(univ_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbUniversidadesuniv_UsuarioModificacionNavigation))]
        public virtual tbUsuarios univ_UsuarioModificacionNavigation { get; set; }
        [InverseProperty("univ")]
        public virtual ICollection<tbRegionales> tbRegionales { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbModulos", Schema = "Accs")]
    [Index(nameof(modu_UrlModulo), Name = "UQ__tbModulo__3061E23DA7E88771", IsUnique = true)]
    [Index(nameof(modu_DescripcionModulo), Name = "UQ__tbModulo__846D0391369F2D2B", IsUnique = true)]
    [Index(nameof(modu_DescripcionModulo), Name = "UQ_tbModulos_modu_DescripcionModulo", IsUnique = true)]
    public partial class tbModulos
    {
        public tbModulos()
        {
            tbModulosPorRoles = new HashSet<tbModulosPorRoles>();
        }

        [Key]
        public int modu_Id { get; set; }
        [Required]
        [StringLength(50)]
        public string modu_DescripcionModulo { get; set; }
        [StringLength(100)]
        public string modu_Titulo { get; set; }
        [StringLength(100)]
        public string modu_Categoria { get; set; }
        [StringLength(100)]
        public string modu_Subcategoria { get; set; }
        [Required]
        [StringLength(255)]
        public string modu_UrlModulo { get; set; }
        public int? modu_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? modu_FechaCreacion { get; set; }
        public int? modu_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? modu_FechaModificacion { get; set; }
        public bool? modu_Estado { get; set; }

        [ForeignKey(nameof(modu_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbModulosmodu_UsuarioCreacionNavigation))]
        public virtual tbUsuarios modu_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(modu_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbModulosmodu_UsuarioModificacionNavigation))]
        public virtual tbUsuarios modu_UsuarioModificacionNavigation { get; set; }
        [InverseProperty("modu")]
        public virtual ICollection<tbModulosPorRoles> tbModulosPorRoles { get; set; }
    }
}
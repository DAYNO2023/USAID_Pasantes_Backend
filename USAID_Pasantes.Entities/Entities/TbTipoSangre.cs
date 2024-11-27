﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbTipoSangre", Schema = "Gral")]
    [Index(nameof(tisa_Descripcion), Name = "UQ_tbTipoSangre_tisa_Descripcion", IsUnique = true)]
    public partial class tbTipoSangre
    {
        public tbTipoSangre()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
            tbOptantes = new HashSet<tbOptantes>();
        }

        [Key]
        public int tisa_Id { get; set; }
        [StringLength(5)]
        public string tisa_Descripcion { get; set; }
        public int? tisa_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? tisa_FechaCreacion { get; set; }
        public int? tisa_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? tisa_Fechamodificacion { get; set; }
        public bool? tisa_Estado { get; set; }

        [ForeignKey(nameof(tisa_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbTipoSangretisa_UsuarioCreacionNavigation))]
        public virtual tbUsuarios tisa_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(tisa_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbTipoSangretisa_UsuarioModificacionNavigation))]
        public virtual tbUsuarios tisa_UsuarioModificacionNavigation { get; set; }
        [InverseProperty("tisa")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        [InverseProperty("tisa")]
        public virtual ICollection<tbOptantes> tbOptantes { get; set; }
    }
}
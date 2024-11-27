﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbForosPorEmpleados", Schema = "Comn")]
    public partial class tbForosPorEmpleados
    {
        [Key]
        public int foem_Id { get; set; }
        public int foro_Id { get; set; }
        [Required]
        public string foem_Descripcion { get; set; }
        public bool foem_ForoProgramado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foem_FechaHoraProgramado { get; set; }
        public int? foem_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foem_FechaCreacion { get; set; }
        public int? foem_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? foem_FechaModificacion { get; set; }
        public bool? foem_Estado { get; set; }

        [ForeignKey(nameof(foem_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbForosPorEmpleadosfoem_UsuarioCreacionNavigation))]
        public virtual tbUsuarios foem_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(foem_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbForosPorEmpleadosfoem_UsuarioModificacionNavigation))]
        public virtual tbUsuarios foem_UsuarioModificacionNavigation { get; set; }
        [ForeignKey(nameof(foro_Id))]
        [InverseProperty(nameof(tbForos.tbForosPorEmpleados))]
        public virtual tbForos foro { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbBeneficios", Schema = "Gest")]
    public partial class tbBeneficios
    {
        public tbBeneficios()
        {
            tbBeneficiosPorOptante = new HashSet<tbBeneficiosPorOptante>();
        }

        [Key]
        public int bene_Id { get; set; }
        [Required]
        [StringLength(30)]
        public string bene_NombreBeneficio { get; set; }
        [Required]
        [StringLength(60)]
        public string bene_DescripcionBeneficio { get; set; }
        [Column(TypeName = "money")]
        public decimal bene_Cantidad { get; set; }
        public int? bene_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? bene_FechaCreacion { get; set; }
        public int? bene_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? bene_FechaModificacion { get; set; }
        public bool? bene_Estado { get; set; }

        [ForeignKey(nameof(bene_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbBeneficiosbene_UsuarioCreacionNavigation))]
        public virtual tbUsuarios bene_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(bene_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbBeneficiosbene_UsuarioModificacionNavigation))]
        public virtual tbUsuarios bene_UsuarioModificacionNavigation { get; set; }
        [InverseProperty("bene")]
        public virtual ICollection<tbBeneficiosPorOptante> tbBeneficiosPorOptante { get; set; }
    }
}
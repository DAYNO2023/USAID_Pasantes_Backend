﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    [Table("tbOptantes", Schema = "Gest")]
    [Index(nameof(opta_DNI), Name = "UQ__tbOptant__659E8FD0D910C988", IsUnique = true)]
    [Index(nameof(opta_CorreoElectronico), Name = "UQ__tbOptant__EE5007D46B9DBF17", IsUnique = true)]
    public partial class tbOptantes
    {
        public tbOptantes()
        {
            tbActividadesPorOptante = new HashSet<tbActividadesPorOptante>();
            tbBeneficiosPorOptante = new HashSet<tbBeneficiosPorOptante>();
            tbDocumentosOptantes = new HashSet<tbDocumentosOptantes>();
            tbHojaTiempoPorOptante = new HashSet<tbHojaTiempoPorOptante>();
            tbRecibosPorOptante = new HashSet<tbRecibosPorOptante>();
            tbRespuestasPorOptante = new HashSet<tbRespuestasPorOptante>();
        }

        [Key]
        public int opta_Id { get; set; }
        [Required]
        public string opta_Imagen { get; set; }
        [Required]
        [StringLength(15)]
        public string opta_DNI { get; set; }
        [Required]
        [StringLength(80)]
        public string opta_Nombres { get; set; }
        [Required]
        [StringLength(80)]
        public string opta_Apellidos { get; set; }
        [Column(TypeName = "date")]
        public DateTime opta_FechaNacimiento { get; set; }
        [Required]
        [StringLength(1)]
        public string opta_Sexo { get; set; }
        [Required]
        [StringLength(50)]
        public string opta_Direccion { get; set; }
        [Required]
        [StringLength(60)]
        public string opta_CorreoElectronico { get; set; }
        [Required]
        [StringLength(9)]
        public string opta_Telefono1 { get; set; }
        [StringLength(9)]
        public string opta_Telefono2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? opta_FechaInicio { get; set; }
        [Column(TypeName = "date")]
        public DateTime? opta_FechaFin { get; set; }
        public string opta_Observacion { get; set; }
        public int? comp_Id { get; set; }
        public int civi_Id { get; set; }
        public int tisa_Id { get; set; }
        [Required]
        [StringLength(4)]
        public string muni_Id { get; set; }
        public int cafr_Id { get; set; }
        public int? banc_Id { get; set; }
        public bool? opta_TipoPago { get; set; }
        [StringLength(30)]
        public string opta_CuentaBancaria { get; set; }
        public bool opta_OptanteAceptado { get; set; }
        public int? opta_UsuarioCreacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? opta_FechaCreacion { get; set; }
        public int? opta_UsuarioModificacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? opta_FechaModificacion { get; set; }
        public bool? opta_Estado { get; set; }

        [ForeignKey(nameof(banc_Id))]
        [InverseProperty(nameof(tbBancos.tbOptantes))]
        public virtual tbBancos banc { get; set; }
        [ForeignKey(nameof(cafr_Id))]
        [InverseProperty(nameof(tbCarreraPorFacultadPorRegional.tbOptantes))]
        public virtual tbCarreraPorFacultadPorRegional cafr { get; set; }
        [ForeignKey(nameof(civi_Id))]
        [InverseProperty(nameof(tbEstadosCiviles.tbOptantes))]
        public virtual tbEstadosCiviles civi { get; set; }
        [ForeignKey(nameof(comp_Id))]
        [InverseProperty(nameof(tbComponentes.tbOptantes))]
        public virtual tbComponentes comp { get; set; }
        [ForeignKey(nameof(muni_Id))]
        [InverseProperty(nameof(tbMunicipios.tbOptantes))]
        public virtual tbMunicipios muni { get; set; }
        [ForeignKey(nameof(opta_UsuarioCreacion))]
        [InverseProperty(nameof(tbUsuarios.tbOptantesopta_UsuarioCreacionNavigation))]
        public virtual tbUsuarios opta_UsuarioCreacionNavigation { get; set; }
        [ForeignKey(nameof(opta_UsuarioModificacion))]
        [InverseProperty(nameof(tbUsuarios.tbOptantesopta_UsuarioModificacionNavigation))]
        public virtual tbUsuarios opta_UsuarioModificacionNavigation { get; set; }
        [ForeignKey(nameof(tisa_Id))]
        [InverseProperty(nameof(tbTipoSangre.tbOptantes))]
        public virtual tbTipoSangre tisa { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbActividadesPorOptante> tbActividadesPorOptante { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbBeneficiosPorOptante> tbBeneficiosPorOptante { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbDocumentosOptantes> tbDocumentosOptantes { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbHojaTiempoPorOptante> tbHojaTiempoPorOptante { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbRecibosPorOptante> tbRecibosPorOptante { get; set; }
        [InverseProperty("opta")]
        public virtual ICollection<tbRespuestasPorOptante> tbRespuestasPorOptante { get; set; }
    }
}
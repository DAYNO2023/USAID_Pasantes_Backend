﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
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

        public int opta_Id { get; set; }
        public string opta_Imagen { get; set; }
        public string opta_DNI { get; set; }
        public string opta_Nombres { get; set; }
        public string opta_Apellidos { get; set; }
        public DateTime opta_FechaNacimiento { get; set; }
        public string opta_Sexo { get; set; }
        public string opta_Direccion { get; set; }
        public string opta_CorreoElectronico { get; set; }
        public string opta_Telefono1 { get; set; }
        public string opta_Telefono2 { get; set; }
        public DateTime? opta_FechaInicio { get; set; }
        public DateTime? opta_FechaFin { get; set; }
        public string opta_Observacion { get; set; }
        public int? comp_Id { get; set; }
        public int civi_Id { get; set; }
        public int tisa_Id { get; set; }
        public string muni_Id { get; set; }
        public int cafr_Id { get; set; }
        public int? banc_Id { get; set; }
        public bool? opta_TipoPago { get; set; }
        public string opta_CuentaBancaria { get; set; }
        public bool opta_OptanteAceptado { get; set; }
        public int? opta_UsuarioCreacion { get; set; }
        public DateTime? opta_FechaCreacion { get; set; }
        public int? opta_UsuarioModificacion { get; set; }
        public DateTime? opta_FechaModificacion { get; set; }
        public bool? opta_Estado { get; set; }

        public virtual tbBancos banc { get; set; }
        public virtual tbCarreraPorFacultadPorRegional cafr { get; set; }
        public virtual tbEstadosCiviles civi { get; set; }
        public virtual tbComponentes comp { get; set; }
        public virtual tbMunicipios muni { get; set; }
        public virtual tbUsuarios opta_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios opta_UsuarioModificacionNavigation { get; set; }
        public virtual tbTipoSangre tisa { get; set; }
        public virtual ICollection<tbActividadesPorOptante> tbActividadesPorOptante { get; set; }
        public virtual ICollection<tbBeneficiosPorOptante> tbBeneficiosPorOptante { get; set; }
        public virtual ICollection<tbDocumentosOptantes> tbDocumentosOptantes { get; set; }
        public virtual ICollection<tbHojaTiempoPorOptante> tbHojaTiempoPorOptante { get; set; }
        public virtual ICollection<tbRecibosPorOptante> tbRecibosPorOptante { get; set; }
        public virtual ICollection<tbRespuestasPorOptante> tbRespuestasPorOptante { get; set; }
    }
}
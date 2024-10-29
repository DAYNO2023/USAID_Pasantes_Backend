﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbHojaTiempo
    {
        public tbHojaTiempo()
        {
            tbHojaTiempoPorOptante = new HashSet<tbHojaTiempoPorOptante>();
        }

        public int hoti_Id { get; set; }
        public int comp_Id { get; set; }
        public DateTime hoti_PeriodoInicio { get; set; }
        public DateTime? hoti_PeriodoFinal { get; set; }
        public DateTime hoti_FechaHoraEntregaLimite { get; set; }
        public int? hoti_UsuarioCreacion { get; set; }
        public DateTime? hoti_FechaCreacion { get; set; }
        public int? hoti_UsuarioModificacion { get; set; }
        public DateTime? hoti_FechaModificacion { get; set; }
        public bool? hoti_Estado { get; set; }
        public TimeSpan? hoti_HorasMinimas { get; set; }

        public virtual tbComponentes comp { get; set; }
        public virtual tbUsuarios hoti_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios hoti_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbHojaTiempoPorOptante> tbHojaTiempoPorOptante { get; set; }
    }
}
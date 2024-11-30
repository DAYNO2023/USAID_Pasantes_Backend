﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbProyectos
    {
        public tbProyectos()
        {
            tbComponentes = new HashSet<tbComponentes>();
            tbDocumentosProyectos = new HashSet<tbDocumentosProyectos>();
        }

        public int pryt_Id { get; set; }
        public string pryt_DescripcionProyecto { get; set; }
        public decimal? pryt_HorasProceso { get; set; }
        public int empr_Id { get; set; }
        public int? pryt_UsuarioCreacion { get; set; }
        public DateTime? pryt_FechaCreacion { get; set; }
        public int? pryt_UsuarioModificacion { get; set; }
        public DateTime? pryt_FechaModificacion { get; set; }
        public bool? pryt_Estado { get; set; }

        public virtual tbEmpresas empr { get; set; }
        public virtual tbUsuarios pryt_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios pryt_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbComponentes> tbComponentes { get; set; }
        public virtual ICollection<tbDocumentosProyectos> tbDocumentosProyectos { get; set; }
    }
}
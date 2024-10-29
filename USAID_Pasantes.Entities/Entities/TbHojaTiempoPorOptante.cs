﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class TbHojaTiempoPorOptante
    {
        public int HotoId { get; set; }
        public int HotiId { get; set; }
        public int OptaId { get; set; }
        public decimal? HotoHorasTotalesRealizadas { get; set; }
        public string HotoComentario { get; set; }
        public DateTime? HotoFechaHoraEntrega { get; set; }
        public bool HotiAprobada { get; set; }
        public int? HotoUsuarioCreacion { get; set; }
        public DateTime? HotoFechaCreacion { get; set; }
        public int? HotoUsuarioModificacion { get; set; }
        public DateTime? HotoFechaModificacion { get; set; }
        public bool? HotoEstado { get; set; }

        public virtual TbHojaTiempo Hoti { get; set; }
        public virtual TbUsuarios HotoUsuarioCreacionNavigation { get; set; }
        public virtual TbUsuarios HotoUsuarioModificacionNavigation { get; set; }
        public virtual TbOptantes Opta { get; set; }
    }
}
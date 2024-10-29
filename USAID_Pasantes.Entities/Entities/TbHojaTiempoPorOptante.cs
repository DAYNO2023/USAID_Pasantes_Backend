﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace USAID_Pasantes.Entities.Entities
{
    public partial class tbHojaTiempoPorOptante
    {
        public int hoto_Id { get; set; }
        public int hoti_Id { get; set; }
        public int opta_Id { get; set; }
        public decimal? hoto_HorasTotalesRealizadas { get; set; }
        public string hoto_Comentario { get; set; }
        public DateTime? hoto_FechaHoraEntrega { get; set; }
        public bool hoti_Aprobada { get; set; }
        public int? hoto_UsuarioCreacion { get; set; }
        public DateTime? hoto_FechaCreacion { get; set; }
        public int? hoto_UsuarioModificacion { get; set; }
        public DateTime? hoto_FechaModificacion { get; set; }
        public bool? hoto_Estado { get; set; }

        public virtual tbHojaTiempo hoti { get; set; }
        public virtual tbUsuarios hoto_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios hoto_UsuarioModificacionNavigation { get; set; }
        public virtual tbOptantes opta { get; set; }
    }
}
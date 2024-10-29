using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class ComponenteViewModel
    {
        public int comp_Id { get; set; }
        public int pryt_Id { get; set; }
        public string comp_NombreComponente { get; set; }
        public string comp_DescripcionComponente { get; set; }
        public TimeSpan comp_HorasAsignadas { get; set; }
        public TimeSpan? comp_HorasCumplidas { get; set; }
        public DateTime comp_FechaInicio { get; set; }
        public DateTime comp_FechaFin { get; set; }
        public string comp_Observacion { get; set; }
        public bool? comp_ComponenteFinalizado { get; set; }
        public int? comp_UsuarioCreacion { get; set; }
        public DateTime? comp_FechaCreacion { get; set; }
        public int? comp_UsuarioModificacion { get; set; }
        public DateTime? comp_FechaModificacion { get; set; }
        public bool? comp_Estado { get; set; }
    }
}

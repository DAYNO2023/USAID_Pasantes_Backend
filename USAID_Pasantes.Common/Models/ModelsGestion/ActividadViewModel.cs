using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class ActividadViewModel
    {
        public int acti_Id { get; set; }
        public int? comp_Id { get; set; }
        public string muni_Id { get; set; }
        public bool acti_PresencialOVirtual { get; set; }
        public string acti_NombreActividad { get; set; }
        public string acti_DescripcionActividad { get; set; }
        public TimeSpan? acti_Horas { get; set; }
        public DateTime acti_FechaInicio { get; set; }
        public DateTime? acti_FechaFinal { get; set; }
        public string acti_DireccionExacta { get; set; }
        public int? acti_UsuarioCreacion { get; set; }
        public DateTime? acti_FechaCreacion { get; set; }
        public int? acti_UsuarioModificacion { get; set; }
        public DateTime? acti_FechaModificacion { get; set; }
        public bool? acti_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class ForoPorActividadViewModel
    {
        public int foac_Id { get; set; }
        public int foro_Id { get; set; }
        public int? acti_Id { get; set; }
        public int? comp_Id { get; set; }
        public bool foac_ForoProgramado { get; set; }
        public bool? foac_OtorgaHoras { get; set; }
        public string foac_Descripcion { get; set; }
        public TimeSpan? foac_Horas { get; set; }
        public DateTime? foac_FechaHoraProgramado { get; set; }
        public int? foac_UsuarioCreacion { get; set; }
        public DateTime? foac_FechaCreacion { get; set; }
        public int? foac_UsuarioModificacion { get; set; }
        public DateTime? foac_FechaModificacion { get; set; }
        public bool? foac_Estado { get; set; }
    }
}

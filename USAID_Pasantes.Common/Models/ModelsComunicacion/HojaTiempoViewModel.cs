using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class HojaTiempoViewModel
    {
        public int hoti_Id { get; set; }
        public int comp_Id { get; set; }
        public DateTime hoti_PeriodoInicio { get; set; }
        public DateTime? hoti_PeriodoFinal { get; set; }
        public DateTime hoti_FechaHoraEntregaLimite { get; set; }
        public TimeSpan? hoti_HorasMinimas { get; set; }
        public int? hoti_UsuarioCreacion { get; set; }
        public DateTime? hoti_FechaCreacion { get; set; }
        public int? hoti_UsuarioModificacion { get; set; }
        public DateTime? hoti_FechaModificacion { get; set; }
        public bool? hoti_Estado { get; set; }
    }
}

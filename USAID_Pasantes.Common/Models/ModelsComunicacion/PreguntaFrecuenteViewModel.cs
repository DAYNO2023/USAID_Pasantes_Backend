using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class PreguntaFrecuenteViewModel
    {
        public int prfr_Id { get; set; }
        public string prfr_Pregunta { get; set; }
        public string prfr_Respuesta { get; set; }
        public int? prfr_UsuarioCreacion { get; set; }
        public DateTime? prfr_FechaCreacion { get; set; }
        public int? prfr_UsuarioModificacion { get; set; }
        public DateTime? prfr_FechaModificacion { get; set; }
        public bool? prfr_Estado { get; set; }
    }
}

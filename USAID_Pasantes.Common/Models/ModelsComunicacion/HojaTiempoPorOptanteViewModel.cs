using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class HojaTiempoPorOptanteViewModel
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class ActividadPorOptanteViewModel
    {
        public int acpe_Id { get; set; }
        public int acti_Id { get; set; }
        public int opta_Id { get; set; }
        public int? acpe_HorasCumplidas { get; set; }
        public string acpe_Observacion { get; set; }
        public int? acpe_UsuarioCreacion { get; set; }
        public DateTime? acpe_FechaCreacion { get; set; }
        public int? acpe_UsuarioModificacion { get; set; }
        public DateTime? acpe_FechaModificacion { get; set; }
        public bool? acpe_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class EstadosCivilesViewModel
    {
        public int civi_Id { get; set; }
        public string civi_DescripcionEstadoCivil { get; set; }
        public int? civi_UsuarioCreacion { get; set; }
        public DateTime? civi_FechaCreacion { get; set; }
        public int? civi_UsuarioModificacion { get; set; }
        public DateTime? civi_FechaModificacion { get; set; }
        public bool? civi_Estado { get; set; }
    }
}

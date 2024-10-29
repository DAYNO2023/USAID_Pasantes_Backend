using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class BancoViewModel
    {
        public int banc_Id { get; set; }
        public string banc_Descripcion { get; set; }
        public int? banc_UsuarioCreacion { get; set; }
        public DateTime? banc_FechaCreacion { get; set; }
        public int? banc_UsuarioModificacion { get; set; }
        public DateTime? banc_FechaModificacion { get; set; }
        public bool? banc_Estado { get; set; }
    }
}

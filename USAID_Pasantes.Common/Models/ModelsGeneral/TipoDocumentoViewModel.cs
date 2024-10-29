using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class TipoDocumentoViewModel
    {
        public int tido_Id { get; set; }
        public string tido_Descripcion { get; set; }
        public int? tido_UsuarioCreacion { get; set; }
        public DateTime? tido_FechaCreacion { get; set; }
        public int? tido_UsuarioModificacion { get; set; }
        public DateTime? tido_FechaModificacion { get; set; }
        public bool? tido_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class DocumentoOptanteViewModel
    {
        public int doop_Id { get; set; }
        public int tido_Id { get; set; }
        public int opta_Id { get; set; }
        public string doop_Descripcion { get; set; }
        public int? doop_UsuarioCreacion { get; set; }
        public DateTime? doop_FechaCreacion { get; set; }
        public int? doop_UsuarioModificacion { get; set; }
        public DateTime? doop_FechaModificacion { get; set; }
        public bool? doop_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class DocumentoViewModel
    {
        public int docu_Id { get; set; }
        public int tido_Id { get; set; }
        public string docu_Descripcion { get; set; }
        public int? docu_UsuarioCreacion { get; set; }
        public DateTime? docu_FechaCreacion { get; set; }
        public int? docu_UsuarioModificacion { get; set; }
        public DateTime? docu_FechaModificacion { get; set; }
        public bool? docu_Estado { get; set; }
    }
}

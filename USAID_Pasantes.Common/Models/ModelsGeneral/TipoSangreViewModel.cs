using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class TipoSangreViewModel
    {
        public int tisa_Id { get; set; }
        public string tisa_Descripcion { get; set; }
        public int? tisa_UsuarioCreacion { get; set; }
        public DateTime? tisa_FechaCreacion { get; set; }
        public int? tisa_UsuarioModificacion { get; set; }
        public DateTime? tisa_Fechamodificacion { get; set; }
        public bool? tisa_Estado { get; set; }
    }
}

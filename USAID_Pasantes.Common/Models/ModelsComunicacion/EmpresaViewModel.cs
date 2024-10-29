using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class EmpresaViewModel
    {
        public int empr_Id { get; set; }
        public string muni_Id { get; set; }
        public string empr_Logo { get; set; }
        public string empr_DescripcionEmpresa { get; set; }
        public string empr_Siglas { get; set; }
        public string empr_DireccionExacta { get; set; }
        public int? empr_UsuarioCreacion { get; set; }
        public DateTime? empr_FechaCreacion { get; set; }
        public int? empr_UsuarioModificacion { get; set; }
        public DateTime? empr_FechaModificacion { get; set; }
        public bool? empr_Estado { get; set; }
    }
}

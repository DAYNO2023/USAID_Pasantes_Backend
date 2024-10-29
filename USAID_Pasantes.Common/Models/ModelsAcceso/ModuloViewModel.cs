using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsAcceso
{
    public class ModuloViewModel
    {
        public int modu_Id { get; set; }
        public string modu_DescripcionModulo { get; set; }
        public string modu_UrlModulo { get; set; }
        public int? modu_UsuarioCreacion { get; set; }
        public DateTime? modu_FechaCreacion { get; set; }
        public int? modu_UsuarioModificacion { get; set; }
        public DateTime? modu_FechaModificacion { get; set; }
        public bool? modu_Estado { get; set; }
    }
}

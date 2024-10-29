using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class ForoViewModel
    {
        public int foro_Id { get; set; }
        public string foro_Titulo { get; set; }
        public bool foro_EsNacional { get; set; }
        public bool foro_EsParaEmpleados { get; set; }
        public int? foro_UsuarioCreacion { get; set; }
        public DateTime? foro_FechaCreacion { get; set; }
        public int? foro_UsuarioModificacion { get; set; }
        public DateTime? foro_FechaModificacion { get; set; }
        public bool? foro_Estado { get; set; }
    }
}

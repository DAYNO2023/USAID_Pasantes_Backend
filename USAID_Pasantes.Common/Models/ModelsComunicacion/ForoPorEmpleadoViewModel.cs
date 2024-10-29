using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class ForoPorEmpleadoViewModel
    {
        public int foem_Id { get; set; }
        public int foro_Id { get; set; }
        public string foem_Descripcion { get; set; }
        public bool foem_ForoProgramado { get; set; }
        public DateTime? foem_FechaHoraProgramado { get; set; }
        public int? foem_UsuarioCreacion { get; set; }
        public DateTime? foem_FechaCreacion { get; set; }
        public int? foem_UsuarioModificacion { get; set; }
        public DateTime? foem_FechaModificacion { get; set; }
        public bool? foem_Estado { get; set; }
    }
}

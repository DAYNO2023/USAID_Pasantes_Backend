using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class DepartamentoViewModel
    {
        public string depa_Id { get; set; }
        public string depa_DescripcionDepartamento { get; set; }
        public int? depa_UsuarioCreacion { get; set; }
        public DateTime? depa_FechaCreacion { get; set; }
        public int? depa_UsuarioModificacion { get; set; }
        public DateTime? depa_FechaModificacion { get; set; }
        public bool? depa_Estado { get; set; }
    }
}

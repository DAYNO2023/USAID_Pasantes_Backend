using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class UniversidadViewModel
    {
        public int univ_Id { get; set; }
        public string univ_DescripcionUniversidad { get; set; }
        public string univ_Abreviatura { get; set; }
        public int? univ_UsuarioCreacion { get; set; }
        public DateTime? univ_FechaCreacion { get; set; }
        public int? univ_UsuarioModificacion { get; set; }
        public DateTime? univ_FechaModificacion { get; set; }
        public bool? univ_Estado { get; set; }
    }
}

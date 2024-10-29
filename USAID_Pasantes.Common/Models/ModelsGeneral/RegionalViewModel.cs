using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class RegionalViewModel
    {
        public int regi_Id { get; set; }
        public int univ_Id { get; set; }
        public string muni_Id { get; set; }
        public string regi_DescripcionRegional { get; set; }
        public string regi_Abreviatura { get; set; }
        public int? regi_UsuarioCreacion { get; set; }
        public DateTime? regi_FechaCreacion { get; set; }
        public int? regi_UsuarioModificacion { get; set; }
        public DateTime? regi_FechaModificacion { get; set; }
        public bool? regi_Estado { get; set; }
    }
}

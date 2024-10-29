using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class MunicipioViewModel
    {
        public string muni_Id { get; set; }
        public string depa_Id { get; set; }
        public string muni_DescripcionMunicipio { get; set; }
        public int? muni_UsuarioCreacion { get; set; }
        public DateTime? muni_FechaCreacion { get; set; }
        public int? muni_UsuarioModificacion { get; set; }
        public DateTime? muni_FechaModificacion { get; set; }
        public bool? muni_Estado { get; set; }
    }
}

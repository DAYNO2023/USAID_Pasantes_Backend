using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class RegionalCorporativaViewModel
    {
        public int reco_Id { get; set; }
        public string muni_Id { get; set; }
        public string reco_NombreRegionalCorportiva { get; set; }
        public string reco_DireccionExacta { get; set; }
        public int? reco_UsuarioCreacion { get; set; }
        public DateTime? reco_FechaCreacion { get; set; }
        public int? reco_UsuarioModificacion { get; set; }
        public DateTime? reco_FechaModificacion { get; set; }
        public bool? reco_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class RespuestaPorOptanteViewModel
    {
        public int cupa_Id { get; set; }
        public int oppr_Id { get; set; }
        public int opta_Id { get; set; }
        public string cupa_respuesta { get; set; }
        public DateTime cupa_FechaRealizado { get; set; }
    }
}

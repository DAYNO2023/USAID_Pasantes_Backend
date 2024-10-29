using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class OpcionPorPreguntaViewModel
    {
        public int oppr_Id { get; set; }
        public int prcu_Id { get; set; }
        public string oppr_NombreOpcion { get; set; }
        public bool oppr_EsRespuesta { get; set; }
    }
}

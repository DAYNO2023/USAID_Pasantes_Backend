using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class PreguntaPorCuestionarioViewModel
    {
        public int prcu_Id { get; set; }
        public int cues_Id { get; set; }
        public bool prcu_EsRespuestaBreve { get; set; }
        public string prcu_Pregunta { get; set; }
        public decimal? prcu_Puntuacion { get; set; }
    }
}

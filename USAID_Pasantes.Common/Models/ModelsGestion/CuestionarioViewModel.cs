using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class CuestionarioViewModel
    {
        public int cues_Id { get; set; }
        public string cues_NombreCuestionario { get; set; }
        public string cues_DescripcionCuestionario { get; set; }
        public bool cues_EsCalificado { get; set; }
        public decimal? cues_Puntuacion { get; set; }
        public bool cues_CuestionarioProgramado { get; set; }
        public DateTime? cues_FechaHoraProgramado { get; set; }
        public int cues_UsuarioCreacion { get; set; }
        public DateTime? cues_FechaCreacion { get; set; }
        public int cues_UsuarioModificacion { get; set; }
        public DateTime? cues_FechaModificacion { get; set; }
        public bool? cues_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class ProyectoViewModel
    {
        public int pryt_Id { get; set; }
        public string pryt_DescripcionProyecto { get; set; }
        public decimal? pryt_HorasProceso { get; set; }
        public int empr_Id { get; set; }
        public int? pryt_UsuarioCreacion { get; set; }
        public DateTime? pryt_FechaCreacion { get; set; }
        public int? pryt_UsuarioModificacion { get; set; }
        public DateTime? pryt_FechaModificacion { get; set; }
        public bool? pryt_Estado { get; set; }
    }
}

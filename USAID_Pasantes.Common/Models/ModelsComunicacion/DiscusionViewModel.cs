using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class DiscusionViewModel
    {
        public int disc_Id { get; set; }
        public int fafe_Id { get; set; }
        public int opem_Id { get; set; }
        public bool? disc_EsOptante { get; set; }
        public string disc_Asunto { get; set; }
        public string disc_Mensaje { get; set; }
        public decimal? disc_Horas { get; set; }
        public int? disc_UsuarioCreacion { get; set; }
        public DateTime? disc_FechaCreacion { get; set; }
        public int? disc_UsuarioModificacion { get; set; }
        public DateTime? disc_FechaModificacion { get; set; }
        public bool? disc_Estado { get; set; }
    }
}

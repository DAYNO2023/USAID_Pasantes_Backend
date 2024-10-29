using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class NotificacionPorUsuarioViewModel
    {
        public int napu_Id { get; set; }
        public int usua_Id { get; set; }
        public bool napu_AlertaOnoti { get; set; }
        public int napu_AlertaONoti_Id { get; set; }
        public string napu_Ruta { get; set; }
        public bool napu_Leida { get; set; }
        public int napu_UsuarioCreacion { get; set; }
        public DateTime napu_FechaCreacion { get; set; }
        public int? napu_UsuarioModificacion { get; set; }
        public DateTime? napu_FechaModificacion { get; set; }
        public bool napu_Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class NotificacionViewModel
    {
        public int noti_Id { get; set; }
        public string noti_Descripcion { get; set; }
        public DateTime noti_Fecha { get; set; }
        public string noti_Ruta { get; set; }
        public int noti_UsuarioCreacion { get; set; }
        public DateTime noti_FechaCreacion { get; set; }
        public int? noti_UsuarioModificacion { get; set; }
        public DateTime? noti_FechaModificacion { get; set; }
        public bool? noti_Estado { get; set; }
    }
}

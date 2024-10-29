using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsAcceso
{
    public class UsuarioViewModel
    {
        public int usua_Id { get; set; }
        public int emop_Id { get; set; }
        public int role_Id { get; set; }
        public bool usua_Administrador { get; set; }
        public bool usua_EsOptante { get; set; }
        public string usua_Usuario { get; set; }
        public string usua_Contraseña { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public DateTime? usua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? usua_FechaModificacion { get; set; }
        public bool? usua_Estado { get; set; }
    }
}

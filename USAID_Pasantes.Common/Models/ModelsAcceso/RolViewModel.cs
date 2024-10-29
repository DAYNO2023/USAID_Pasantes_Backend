using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsAcceso
{
    public class RolViewModel
    {
        public int role_Id { get; set; }
        public string role_DescripcionRol { get; set; }
        public int? role_UsuarioCreacion { get; set; }
        public DateTime? role_FechaCreacion { get; set; }
        public int? role_UsuarioModificacion { get; set; }
        public DateTime? role_FechaModificacion { get; set; }
        public bool? role_Estado { get; set; }
    }
}

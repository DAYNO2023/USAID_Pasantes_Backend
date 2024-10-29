using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class FacultadViewModel
    {
        public int facu_Id { get; set; }
        public string facu_DesripcionFacultad { get; set; }
        public int? facu_UsuarioCreacion { get; set; }
        public DateTime? facu_FechaCreacion { get; set; }
        public int? facu_UsuarioModificacion { get; set; }
        public DateTime? facu_FechaModificacion { get; set; }
        public bool? facu_Estado { get; set; }
    }
}

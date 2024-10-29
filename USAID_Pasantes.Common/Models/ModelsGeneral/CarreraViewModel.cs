using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class CarreraViewModel
    {
        public int carr_Id { get; set; }
        public string carr_DescripcionCarrera { get; set; }
        public int? carr_UsuarioCreacion { get; set; }
        public DateTime? carr_FechaCreacion { get; set; }
        public int? carr_UsuarioModificacion { get; set; }
        public DateTime? carr_FechaModificacion { get; set; }
        public bool? carr_Estado { get; set; }
    }
}

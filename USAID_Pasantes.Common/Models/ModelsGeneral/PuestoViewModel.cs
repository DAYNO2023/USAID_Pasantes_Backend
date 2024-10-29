using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class PuestoViewModel
    {
        public int pust_Id { get; set; }
        public string pust_DescripcionPuesto { get; set; }
        public int? pust_UsuarioCreacion { get; set; }
        public DateTime? pust_FechaCreacion { get; set; }
        public int? pust_UsuarioModificacion { get; set; }
        public DateTime? pust_FechaModificacion { get; set; }
        public bool? pust_Estado { get; set; }
    }
}

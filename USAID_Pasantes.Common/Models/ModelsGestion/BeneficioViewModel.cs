using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class BeneficioViewModel
    {
        public int bene_Id { get; set; }
        public string bene_NombreBeneficio { get; set; }
        public string bene_DescripcionBeneficio { get; set; }
        public decimal bene_Cantidad { get; set; }
        public int? bene_UsuarioCreacion { get; set; }
        public DateTime? bene_FechaCreacion { get; set; }
        public int? bene_UsuarioModificacion { get; set; }
        public DateTime? bene_FechaModificacion { get; set; }
        public bool? bene_Estado { get; set; }
    }
}

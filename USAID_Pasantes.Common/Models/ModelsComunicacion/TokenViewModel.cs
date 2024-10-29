using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsComunicacion
{
    public class TokenViewModel
    {
        public int tokn_Id { get; set; }
        public int usua_Id { get; set; }
        public string tokn_JsonToken { get; set; }
        public bool? tokn_SesionWeb { get; set; }
    }
}

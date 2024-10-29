using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGeneral
{
    public class EmpleadoViewModel
    {
        public int empl_Id { get; set; }
        public string empl_Imagen { get; set; }
        public string empl_DNI { get; set; }
        public string empl_Nombres { get; set; }
        public string empl_Apellidos { get; set; }
        public string empl_Telefono { get; set; }
        public string empl_Correo { get; set; }
        public string empl_Sexo { get; set; }
        public int pust_Id { get; set; }
        public int tisa_Id { get; set; }
        public int civi_Id { get; set; }
        public string muni_Id { get; set; }
        public bool empl_EsContador { get; set; }
        public int? empl_UsuarioCreacion { get; set; }
        public DateTime? empl_FechaCreacion { get; set; }
        public int? empl_UsuarioModificacion { get; set; }
        public DateTime? empl_FechaModificacion { get; set; }
        public bool? empl_Estado { get; set; }
    }
}

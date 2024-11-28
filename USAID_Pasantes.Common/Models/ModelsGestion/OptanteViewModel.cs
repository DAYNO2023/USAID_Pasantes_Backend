using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.Common.Models.ModelsGestion
{
    public class OptanteViewModel
    {
        public int opta_Id { get; set; }
        public string opta_Imagen { get; set; }
        public string opta_DNI { get; set; }
        public string opta_Nombres { get; set; }
        public string opta_Apellidos { get; set; }
        public DateTime opta_FechaNacimiento { get; set; }
        public string opta_Sexo { get; set; }
        public string opta_Direccion { get; set; }
        public string opta_CorreoElectronico { get; set; }
        public string opta_Telefono1 { get; set; }
        public string opta_Telefono2 { get; set; }
        public DateTime? opta_FechaInicio { get; set; }
        public DateTime? opta_FechaFin { get; set; }
        public string opta_Observacion { get; set; }
        public int? comp_Id { get; set; }
        public int civi_Id { get; set; }
        public int tisa_Id { get; set; }
        public string muni_Id { get; set; }
        public int cafr_Id { get; set; }
        public int? banc_Id { get; set; }
        public bool? opta_TipoPago { get; set; }
        public string opta_CuentaBancaria { get; set; }
        public bool opta_OptanteAceptado { get; set; }
        public int? opta_UsuarioCreacion { get; set; }
        public DateTime? opta_FechaCreacion { get; set; }
        public int? opta_UsuarioModificacion { get; set; }
        public DateTime? opta_FechaModificacion { get; set; }
        public bool? opta_Estado { get; set; }
    }
}

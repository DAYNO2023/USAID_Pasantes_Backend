using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.DataAccess
{
    public class ScriptsDataBase
    {
        #region General

        #region Estado Civil
        public static string ListarEstadosCiviles = "[Gral].[SP_ListarEstadosCiviles]";
        public static string BuscarEstadoCivil = "[Gral].[SP_EstadoCivil_Buscar]";
        public static string InsertarEstadoCivil = "[Gral].[SP_EstadoCivil_Insertar]";
        public static string ActualizarEstadoCivil = "[Gral].[SP_EstadoCivil_Actualizar]";
        public static string EliminarEstadoCivil = "[Gral].[SP_EstadoCivil_Eliminar]";
        #endregion
        #endregion
    }
}

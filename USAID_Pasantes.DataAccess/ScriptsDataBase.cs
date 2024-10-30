﻿using System;
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
           public static string ListarEstadosCiviles = "[Gral].[SP_EstadosCiviles_Listar]";
           public static string BuscarEstadoCivil = "[Gral].[SP_EstadoCivil_Buscar]";
           public static string InsertarEstadoCivil = "[Gral].[SP_EstadoCivil_Insertar]";
           public static string ActualizarEstadoCivil = "[Gral].[SP_EstadoCivil_Actualizar]";
           public static string EliminarEstadoCivil = "[Gral].[SP_EstadoCivil_Eliminar]";
        #endregion

        #endregion

        #region Gestion

          #region Beneficio
           public static string ListarBeneficios = "[Gest].[SP_Beneficios_Listar]";
           public static string BuscarBeneficio = "[Gest].[SP_Beneficio_Buscar]";
           public static string InsertarBeneficio = "[Gest].[SP_Beneficio_Insertar]";
           public static string ActualizarBeneficio = "[Gest].[SP_Beneficio_Actualizar]";
           public static string EliminarBeneficio = "[Gest].[SP_Beneficio_Eliminar]";
          #endregion

        #endregion
    }
}

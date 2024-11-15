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

        #region Departamento

        public static string ListarDepartamentos = "";
        public static string BuscarDepartamento = "";
        public static string InsertarDepartamento = "";
        public static string ActualizarDepartamento = "";
        public static string EliminarDepartamento = "";

        #endregion

        #region Carrera
        public static string ListarCarreras = "";
        public static string BuscarCarrera = "";
        public static string InsertarCarrera = "";
        public static string ActualizarCarrera = "";
        public static string EliminarCarrera = "";

        #endregion

        #region Banco
        public static string ListarBancos = "";
        public static string BuscarBanco = "";
        public static string InsertarBanco = "";
        public static string ActualizarBanco = "";
        public static string EliminarBanco = "";

        #endregion

        #region Carrera Por Facultad Por Regional
        public static string ListarCarreraPorFacultadPorRegional = "";
        public static string BuscarCarreraPorFacultadPorRegional = "";
        public static string InsertarCarreraPorFacultadPorRegional = "";
        public static string ActualizarCarreraPorFacultadPorRegional = "";
        public static string EliminarCarreraPorFacultadPorRegional = "";
        #endregion

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

        #region Acceso

        #region Modulos
        public static string ListarModulos = "[Accs].[SP_Modulos_Listar]";
        #endregion

        #region ModulosPorRol
        public static string ListarModulosPorRol = "[Accs].[SP_ModulosPorRol_Listar]";
        public static string BuscarModulosPorRol = "[Accs].[SP_ModulosPorRol_Buscar]";
        public static string InsertarModulosPorRol = "[Accs].[SP_ModulosPorRol_Insertar]";
        public static string ActualizarModulosPorRol = "[Accs].[SP_ModulosPorRol_Actualizar]";
        public static string EliminarModulosPorRol = "[Accs].[SP_ModulosPorRol_Eliminar]";

        #endregion

        #region Rol
        public static string ListarRol = "[Accs].[SP_Roles_Listar]";
        public static string BuscarRol = "[Accs].[SP_Rol_Buscar]";
        public static string InsertarRol = "[Accs].[SP_Rol_Insertar]";
        public static string ActualizarRol = "[Accs].[SP_Rol_Actualizar]";
        public static string EliminarRol = "[Accs].[SP_Rol_Eliminar]";
        #endregion

        #endregion

        #region Comunicacion

        #endregion
    }
}

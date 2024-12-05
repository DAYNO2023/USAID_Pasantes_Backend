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

        #region Carrera
        public static string ListarCarreras = "";
        public static string ListarCarrerasPorFacultadPorRegional = "Gral.SP_Carreras_ListarPorFacultadPorRegional";
        public static string BuscarCarrera = "";
        public static string InsertarCarrera = "";
        public static string ActualizarCarrera = "";
        public static string EliminarCarrera = "";

        #endregion

        #region Departamento

        public static string ListarDepartamentos = "Gral.SP_Departamentos_Listar";
        public static string BuscarDepartamento = "Gral.SP_Departamento_Buscar";
        public static string InsertarDepartamento = "Gral.SP_Departamento_Insertar";
        public static string ActualizarDepartamento = "Gral.SP_Departamento_Actualizar";
        public static string EliminarDepartamento = "";
        #endregion

        #region Empleado
        public static string ListarEmpleados = "";
        public static string BuscarEmpleado = "";
        public static string InsertarEmpleado = "";
        public static string ActualizarEmpleado = "";
        public static string EliminarEmpleado = "";

        #endregion

        #region Facultad Por Regional

        public static string ListarFacultadPorRegional = "";
        public static string BuscarFacultadPorRegional = "";
        public static string InsertarFacultadPorRegional = "";
        public static string ActualizarFacultadPorRegional = "";
        public static string EliminarFacultadPorRegional = "";

        #endregion

        #region Facultad
        public static string ListarFacultades = "";
        public static string ListarFacultadesPorRegional = "Gral.SP_Facultades_ListarPorRegional";
        public static string BuscarFacultad = "";
        public static string InsertarFacultad = "";
        public static string ActualizarFacultad = "";
        public static string EliminarFacultad = "";
        #endregion

        #region Municipio
        public static string ListarMunicipios = "";
        public static string ListarMunicipiosPorDepartamento = "Gral.SP_Municipios_ListarPorDepartamento";
        public static string BuscarMunicipio = "";
        public static string InsertarMunicipio = "";
        public static string ActualizarMunicipio = "";
        public static string EliminarMunicipio = "";
        #endregion

        #region Puesto
        public static string ListarPuestos = "";
        public static string BuscarPuesto = "";
        public static string InsertarPuesto = "";
        public static string ActualizarPuesto = "";
        public static string EliminarPuesto = "";
        #endregion

        #region RegionalCorporativa
        public static string ListarRegionalCorporativas = "";
        public static string BuscarRegionalCorporativa = "";
        public static string InsertarRegionalCorporativa = "";
        public static string ActualizarRegionalCorporativa = "";
        public static string EliminarRegionalCorporativa = "";

        #endregion

        #region Regional
        public static string ListarRegionales = "";
        public static string ListarRegionalesPorUniversidad = "Gral.SP_Regionales_ListarPorUniversidad";
        public static string BuscarRegional = "";
        public static string InsertarRegional = "";
        public static string ActualizarRegional = "";
        public static string EliminarRegional = "";

        #endregion

        #region TipoDocumento
        public static string ListarTipoDocumentos = "";
        public static string BuscarTipoDocumento = "";
        public static string InsertarTipoDocumento = "";
        public static string ActualizarTipoDocumento = "";
        public static string EliminarTipoDocumento = "";
        #endregion

        #region Tipo Sangre
        public static string ListarTipoSangres = "Gral.SP_TiposSangre_Listar";
        public static string BuscarTipoSangre = "Gral.SP_TipoSangre_Buscar";
        public static string InsertarTipoSangre = "Gral.SP_TipoSangre_Insertar";
        public static string ActualizarTipoSangre = "Gral.SP_TipoSangre_Actualizar";
        public static string EliminarTipoSangre = "Gral.SP_TipoSangre_Eliminar";
        #endregion

        #region Universidad
        public static string ListarUniversidades = "Gral.SP_Universidades_Listar";
        public static string BuscarUniversidad = "";
        public static string InsertarUniversidad = "";
        public static string ActualizarUniversidad = "";
        public static string EliminarUniversidad = "";
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

        #region Proyecto
        public static string ListarProyectos = "[Gest].[SP_Proyectos_Listar]";
        public static string BuscarProyecto = "[Gest].[SP_Proyecto_Buscar]";
        public static string InsertarProyecto = "[Gest].[SP_Proyecto_Insertar]";
        public static string ActualizarProyecto = "[Gest].[SP_Proyecto_Actualizar]";
        public static string EliminarProyecto = "[Gest].[SP_Proyecto_Eliminar]";
        #endregion

        #region Optante
        public static string ListarOptantes = "Gest.SP_Optantes_Listar";
        public static string RegistrarOptante = "[Gest].[SP_Optante_Registrar]";
        public static string BuscarOptante = "";
        public static string InsertarOptante = "";
        public static string ActualizarOptante = "";
        public static string EliminarOptante = "";
        #endregion

        #endregion

        #region Acceso

        #region Login
        public static string IniciarSesion = "[Accs].[SP_Usuario_InicioSesion]";
        public static string InsertarCodigoVerificacion = "[Accs].[SP_Usuario_IngresarCodigoRestablecer]";
        public static string VerificarCodigoReestablecer = "[Accs].[SP_Usuario_VerificarCodigoRestablecer]";
        public static string Buscar_Usuario = "[Accs].[SP_Usuario_Buscar]";
        public static string Reestablecer_Usuario = "[Accs].[SP_Usuario_Reestablecer]";

        #endregion

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

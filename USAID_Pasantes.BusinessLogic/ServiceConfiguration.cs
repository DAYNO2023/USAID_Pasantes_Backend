using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesAcceso;
using USAID_Pasantes.BusinessLogic.Services.ServicesGeneral;
using USAID_Pasantes.BusinessLogic.Services.ServicesComunicacion;
using USAID_Pasantes.BusinessLogic.Services.ServicesGestion;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion;

namespace USAID_Pasantes.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAcces(this IServiceCollection service, string connection)
        {
            USAID_Pasantes.DataAccess.USAID_Pasantes.BuildConnectionString(connection);

            #region Acceso
            service.AddScoped<ModuloRepository>();
            service.AddScoped<ModuloPorRolRepository>();
            service.AddScoped<RolRepository>();
            service.AddScoped<LoginRepository>();
            #endregion

            #region Comunicacion
            #endregion

            #region General
            service.AddScoped<EstadoCivilRepository>();
            service.AddScoped<BancoRepository>();
            service.AddScoped<CarreraPorFacultadPorRegionalRepository>();
            service.AddScoped<CarreraRepository>();
            service.AddScoped<DepartamentoRepository>();
            service.AddScoped<EmpleadoRepository>();
            service.AddScoped<FacultadPorRegionalRepository>();
            service.AddScoped<FacultadRepository>();
            service.AddScoped<MunicipioRepository>();
            service.AddScoped<PuestoRepository>();
            service.AddScoped<RegionalCorporativaRepository>();
            service.AddScoped<RegionalRepository>();
            service.AddScoped<TipoDocumentoRepository>();
            service.AddScoped<TipoSangreRepository>();
            service.AddScoped<UniversidadRepository>();
            #endregion

            #region Gestion
            service.AddScoped<BeneficioRepository>();
            service.AddScoped<OptanteRepository>();
            #endregion
        }
        public static void BusinessLogic(this IServiceCollection service)
        {
            #region Acceso
            service.AddScoped<ModuloService>();
            service.AddScoped<ModuloPorRolService>();
            service.AddScoped<RolService>();
            service.AddScoped<LoginService>();
            #endregion

            #region General
            service.AddScoped<EstadoCivilService>();
            service.AddScoped<BancoRepository>();
            service.AddScoped<CarreraPorFacultadPorRegionalService>();
            service.AddScoped<CarreraService>();
            service.AddScoped<DepartamentoService>();
            service.AddScoped<EmpleadoService>();
            service.AddScoped<FacultadPorRegionalService>();
            service.AddScoped<FacultadService>();
            service.AddScoped<MunicipioService>();
            service.AddScoped<PuestoService>();
            service.AddScoped<RegionalCorporativaService>();
            service.AddScoped<RegionalService>();
            service.AddScoped<TipoDocumentoService>();
            service.AddScoped<TipoSangreService>();
            service.AddScoped<UniversidadService>();
            #endregion

            #region Gestion
            service.AddScoped<BeneficioService>();
            service.AddScoped<OptanteService>();
            #endregion
        }
    }
}

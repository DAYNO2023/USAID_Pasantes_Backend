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
            #endregion

            #region Comunicacion
            #endregion

            #region General
            service.AddScoped<EstadoCivilRepository>();
            #endregion

            #region Gestion
            service.AddScoped<BeneficioRepository>();
            #endregion
        }
        public static void BusinessLogic(this IServiceCollection service)
        {
            #region Acceso
            service.AddScoped<ModuloService>();
            service.AddScoped<ModuloPorRolService>();
            service.AddScoped<RolService>();
            #endregion

            #region General
            service.AddScoped<EstadoCivilService>();
            #endregion

            #region Gestion
            service.AddScoped<BeneficioService>();
            #endregion
        }
    }
}

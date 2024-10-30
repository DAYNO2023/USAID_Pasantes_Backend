using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesGeneral;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;

namespace USAID_Pasantes.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAcces(this IServiceCollection service, string connection)
        {
            USAID_Pasantes.DataAccess.USAID_Pasantes.BuildConnectionString(connection);

            #region Acceso
            #endregion

            #region Comunicacion
            #endregion

            #region General
            service.AddScoped<EstadoCivilRepository>();
            #endregion

            #region Gestion
            #endregion
        }
        public static void BusinessLogic(this IServiceCollection service)
        {
            #region General
            service.AddScoped<EstadoCivilService>();
            #endregion
        }
    }
}

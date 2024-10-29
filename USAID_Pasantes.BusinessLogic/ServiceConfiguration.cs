using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAcces(this IServiceCollection service, string connection)
        {
            USAID_Pasantes.DataAccess.USAID_Pasantes.BuildConnectionString(connection);
        }
        public static void BusinessLogic(this IServiceCollection service)
        {

        }
    }
}

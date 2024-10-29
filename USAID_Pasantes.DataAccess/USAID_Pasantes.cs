using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using USAID_Pasantes.DataAccess.Context;

namespace USAID_Pasantes.DataAccess
{
    public class USAID_Pasantes : DB_UsaidpasantesContext
    {
        public static string ConnectionString { get; set; }

        public USAID_Pasantes()
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string connection)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder { ConnectionString = connection };
            ConnectionString = connectionStringBuilder.ConnectionString;
        }

    }
}

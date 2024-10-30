using System;
using System.Collections.Generic;
using USAID_Pasantes.Entities.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso
{
    public class ModuloRepository : IRepository<tbModulos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbModulos Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbModulos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbModulos> List()
        {
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var result = db.Query<tbModulos>(ScriptsDataBase.ListarModulos,
                     commandType: CommandType.StoredProcedure
                    );

                return result;
            }
        }

        public RequestStatus Update(tbModulos item)
        {
            throw new NotImplementedException();
        }
    }
}

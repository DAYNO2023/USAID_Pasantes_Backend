using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral
{
    public class FacultadPorRegionalRepository : IRepository<tbFacultadPorRegional>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@fare_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarFacultadPorRegional, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbFacultadPorRegional Find(int? id)
        {
            tbFacultadPorRegional result = new tbFacultadPorRegional();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@fare_Id", id);
                result = db.QueryFirst<tbFacultadPorRegional>(ScriptsDataBase.BuscarFacultadPorRegional, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbFacultadPorRegional item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@facu_Id", item.facu_Id);
                parameter.Add("@regi_Id", item.regi_Id);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarFacultadPorRegional, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbFacultadPorRegional> List()
        {
            List<tbFacultadPorRegional> result = new List<tbFacultadPorRegional>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbFacultadPorRegional>(ScriptsDataBase.ListarFacultadPorRegional, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbFacultadPorRegional item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@fare_Id", item.fare_Id);
                parameter.Add("@facu_Id", item.facu_Id);
                parameter.Add("@regi_Id", item.regi_Id);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarFacultadPorRegional, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

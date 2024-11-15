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
    public class CarreraPorFacultadPorRegionalRepository : IRepository<tbCarreraPorFacultadPorRegional>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@cafr_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbCarreraPorFacultadPorRegional Find(int? id)
        {
            tbCarreraPorFacultadPorRegional result = new tbCarreraPorFacultadPorRegional();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@cafr_Id", id);
                result = db.QueryFirst<tbCarreraPorFacultadPorRegional>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbCarreraPorFacultadPorRegional item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@cafr_Id", item.cafr_Id);
                parameter.Add("@fare_Id", item.fare_Id);
                parameter.Add("@carr_Id", item.carr_Id);

                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbCarreraPorFacultadPorRegional> List()
        {
            List<tbCarreraPorFacultadPorRegional> result = new List<tbCarreraPorFacultadPorRegional>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbCarreraPorFacultadPorRegional>(ScriptsDataBase., commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbCarreraPorFacultadPorRegional item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@cafr_Id", item.cafr_Id);
                parameter.Add("@fare_Id", item.fare_Id);
                parameter.Add("@carr_Id", item.carr_Id);

                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

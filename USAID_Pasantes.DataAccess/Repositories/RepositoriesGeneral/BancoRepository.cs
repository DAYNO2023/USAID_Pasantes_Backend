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
    public class BancoRepository : IRepository<tbBancos>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@banc_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbBancos Find(int? id)
        {
            tbBancos result = new tbBancos();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@banc_Id", id);
                result = db.QueryFirst<tbBancos>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbBancos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@banc_Descripcion", item.banc_Descripcion);
                parameter.Add("@banc_UsuarioCreacion", item.banc_UsuarioCreacion);
                parameter.Add("@banc_FechaCreacion", item.banc_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbBancos> List()
        {
            List<tbBancos> result = new List<tbBancos>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbBancos>(ScriptsDataBase., commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbBancos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@banc_Id", item.banc_Id);
                parameter.Add("@banc_Descripcion", item.banc_Descripcion);
                parameter.Add("@banc_UsuarioModificacion", item.banc_UsuarioModificacion);
                parameter.Add("@banc_FechaModificacion", item.banc_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

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
    public class RegionalRepository : IRepository<tbRegionales>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@regi_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarRegional, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbRegionales Find(int? id)
        {
            tbRegionales result = new tbRegionales();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@regi_Id", id);
                result = db.QueryFirst<tbRegionales>(ScriptsDataBase.BuscarRegionalCorporativa, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbRegionales item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@regi_DescripcionRegional", item.regi_DescripcionRegional);
                parameter.Add("@regi_Abreviatura", item.regi_Abreviatura);
                parameter.Add("@muni_Id", item.muni_Id);
                parameter.Add("@regi_UsuarioCreacion", item.regi_UsuarioCreacion);
                parameter.Add("@regi_FechaCreacion", item.regi_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarRegionalCorporativa, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbRegionales> List()
        {
            List<tbRegionales> result = new List<tbRegionales>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbRegionales>(ScriptsDataBase.ListarRegionalCorporativas, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbRegionales item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@regi_Id", item.regi_Id);
                parameter.Add("@regi_DescripcionRegional", item.regi_DescripcionRegional);
                parameter.Add("@regi_Abreviatura", item.regi_Abreviatura);
                parameter.Add("@muni_Id", item.muni_Id);
                parameter.Add("@regi_UsuarioModificacion", item.regi_UsuarioModificacion);
                parameter.Add("@regi_FechaModificacion", item.regi_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarRegionalCorporativa, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

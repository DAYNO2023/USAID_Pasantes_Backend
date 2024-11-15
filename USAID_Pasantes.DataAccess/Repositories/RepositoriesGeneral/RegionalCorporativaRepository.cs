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
    public class RegionalCorporativaRepository : IRepository<tbRegionalCorporativa>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@reco_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbRegionalCorporativa Find(int? id)
        {
            tbRegionalCorporativa result = new tbRegionalCorporativa();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@reco_Id", id);
                result = db.QueryFirst<tbRegionalCorporativa>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbRegionalCorporativa item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_DescripcionEstadoCivil", item.reco_NombreRegionalCorportiva);
                parameter.Add("@reco_DireccionExacta", item.reco_DireccionExacta);
                parameter.Add("@muni_Id", item.muni_Id);
                parameter.Add("@reco_UsuarioCreacion", item.reco_UsuarioCreacion);
                parameter.Add("@reco_FechaCreacion", item.reco_FechaCreacion);


                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbRegionalCorporativa> List()
        {
            List<tbRegionalCorporativa> result = new List<tbRegionalCorporativa>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbRegionalCorporativa>(ScriptsDataBase., commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbRegionalCorporativa item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@reco_Id", item.reco_Id);
                parameter.Add("@civi_DescripcionEstadoCivil", item.reco_NombreRegionalCorportiva);
                parameter.Add("@reco_DireccionExacta", item.reco_DireccionExacta);
                parameter.Add("@muni_Id", item.muni_Id);
                parameter.Add("@reco_UsuarioModificacion", item.reco_UsuarioModificacion);
                parameter.Add("@reco_FechaModificacion", item.reco_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase., parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

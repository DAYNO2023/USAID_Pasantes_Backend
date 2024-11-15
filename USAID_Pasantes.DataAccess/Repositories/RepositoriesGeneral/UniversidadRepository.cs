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
    public class UniversidadRepository : IRepository<tbUniversidades>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@univ_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarUniversidad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbUniversidades Find(int? id)
        {
            tbUniversidades result = new tbUniversidades();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@univ_Id", id);
                result = db.QueryFirst<tbUniversidades>(ScriptsDataBase.BuscarUniversidad, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbUniversidades item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@univ_DescripcionUniversidad", item.univ_DescripcionUniversidad);
                parameter.Add("@univ_Abreviatura", item.univ_Abreviatura);
                parameter.Add("@univ_UsuarioCreacion", item.univ_UsuarioCreacion);
                parameter.Add("@univ_FechaCreacion", item.univ_FechaCreacion);


                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarUniversidad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbUniversidades> List()
        {
            List<tbUniversidades> result = new List<tbUniversidades>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbUniversidades>(ScriptsDataBase.ListarUniversidades, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbUniversidades item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@univ_Id", item.univ_Id);
                parameter.Add("@univ_DescripcionUniversidad", item.univ_DescripcionUniversidad);
                parameter.Add("@univ_Abreviatura", item.univ_Abreviatura);
                parameter.Add("@univ_UsuarioModificacion", item.univ_UsuarioModificacion);
                parameter.Add("@univ_FechaModificacion", item.univ_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarUniversidad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

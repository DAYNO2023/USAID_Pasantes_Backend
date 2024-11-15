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
    public class DepartamentoRepository : IRepository<tbDepartamentos>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@depa_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarDepartamento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbDepartamentos Find(int? id)
        {
            tbDepartamentos result = new tbDepartamentos();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@depa_Id", id);
                result = db.QueryFirst<tbDepartamentos>(ScriptsDataBase.BuscarDepartamento, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbDepartamentos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@depa_DescripcionDepartamento", item.depa_DescripcionDepartamento);
                parameter.Add("@depa_UsuarioCreacion", item.depa_UsuarioCreacion);
                parameter.Add("@depa_FechaCreacion", item.depa_FechaCreacion);


                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarDepartamento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbDepartamentos> List()
        {
            List<tbDepartamentos> result = new List<tbDepartamentos>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(ScriptsDataBase.ListarDepartamentos, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbDepartamentos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@depa_Id", item.depa_Id);
                parameter.Add("@depa_DescripcionDepartamento", item.depa_DescripcionDepartamento);
                parameter.Add("@depa_UsuarioModificacion", item.depa_UsuarioModificacion);
                parameter.Add("@depa_FechaModificacion", item.depa_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarDepartamento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

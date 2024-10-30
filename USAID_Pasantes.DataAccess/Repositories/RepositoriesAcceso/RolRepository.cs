using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso
{
    public class RolRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", id);

                var answer = db.QueryFirst<int>(
                    ScriptsDataBase.EliminarRol,
                    parameter,
                    commandType: CommandType.StoredProcedure
                );

                result.CodeStatus = answer;
                return result;
            }
        }

        public tbRoles Find(int? id)
        {
            tbRoles result = new tbRoles();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", id);
                result = db.QueryFirst<tbRoles>(ScriptsDataBase.BuscarRol, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbRoles item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_DescripcionRol", item.role_DescripcionRol);
                parameter.Add("@Role_UsuarioCreacion", item.role_UsuarioCreacion);
                parameter.Add("@Role_FechaCreacion", item.role_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarRol, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbRoles> List()
        {
            List<tbRoles> result = new List<tbRoles>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbRoles>(ScriptsDataBase.ListarRol, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbRoles item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", item.role_Id);
                parameter.Add("@Role_DescripcionRol", item.role_DescripcionRol);
                parameter.Add("@Role_UsuarioModificacion", item.role_UsuarioModificacion);
                parameter.Add("@Role_FechaModificacion", item.role_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarRol, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

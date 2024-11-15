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
    public class TipoSangreRepository : IRepository<tbTipoSangre>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tisa_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarTipoSangre, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbTipoSangre Find(int? id)
        {
            tbTipoSangre result = new tbTipoSangre();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tisa_Id", id);
                result = db.QueryFirst<tbTipoSangre>(ScriptsDataBase.BuscarTipoSangre, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbTipoSangre item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tisa_Descripcion", item.tisa_Descripcion);
                parameter.Add("@tisa_UsuarioCreacion", item.tisa_UsuarioCreacion);
                parameter.Add("@tisa_FechaCreacion", item.tisa_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarTipoSangre, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbTipoSangre> List()
        {
            List<tbTipoSangre> result = new List<tbTipoSangre>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbTipoSangre>(ScriptsDataBase.ListarTipoSangres, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbTipoSangre item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tisa_Id", item.tisa_Id);
                parameter.Add("@tisa_Descripcion", item.tisa_Descripcion);
                parameter.Add("@tisa_UsuarioModificacion", item.tisa_UsuarioModificacion);
                parameter.Add("@tisa_Fechamodificacion", item.tisa_Fechamodificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarTipoSangre, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

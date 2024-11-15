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
    public class TipoDocumentoRepository : IRepository<tbTipoDocumento>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tido_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarTipoDocumento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbTipoDocumento Find(int? id)
        {
            tbTipoDocumento result = new tbTipoDocumento();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tido_Id", id);
                result = db.QueryFirst<tbTipoDocumento>(ScriptsDataBase.BuscarTipoDocumento, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbTipoDocumento item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tido_Descripcion", item.tido_Descripcion);
                parameter.Add("@tido_UsuarioCreacion", item.tido_UsuarioCreacion);
                parameter.Add("@tido_FechaCreacion", item.tido_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarTipoDocumento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbTipoDocumento> List()
        {
            List<tbTipoDocumento> result = new List<tbTipoDocumento>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbTipoDocumento>(ScriptsDataBase.ListarTipoDocumentos, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbTipoDocumento item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@tido_Id", item.tido_Id);
                parameter.Add("@tido_Descripcion", item.tido_Descripcion);
                parameter.Add("@tido_UsuarioModificacion", item.tido_UsuarioModificacion);
                parameter.Add("@tido_FechaModificacion", item.tido_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarTipoDocumento, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

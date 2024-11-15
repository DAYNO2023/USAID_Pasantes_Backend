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
    public class PuestoRepository : IRepository<tbPuestos>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pust_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarPuesto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbPuestos Find(int? id)
        {
            tbPuestos result = new tbPuestos();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pust_Id", id);
                result = db.QueryFirst<tbPuestos>(ScriptsDataBase.BuscarPuesto, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbPuestos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pust_DescripcionPuesto", item.pust_DescripcionPuesto);
                parameter.Add("@pust_UsuarioCreacion", item.pust_UsuarioCreacion);
                parameter.Add("@pust_FechaCreacion", item.pust_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarPuesto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbPuestos> List()
        {
            List<tbPuestos> result = new List<tbPuestos>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbPuestos>(ScriptsDataBase.ListarPuestos, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbPuestos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pust_Id", item.pust_Id);
                parameter.Add("@pust_DescripcionPuesto", item.pust_DescripcionPuesto);
                parameter.Add("@pust_UsuarioModificacion", item.pust_UsuarioModificacion);
                parameter.Add("@pust_FechaModificacion", item.pust_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarPuesto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

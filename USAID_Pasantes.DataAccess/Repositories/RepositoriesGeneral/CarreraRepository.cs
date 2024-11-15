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
    public class CarreraRepository : IRepository<tbCarreras>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@carr_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarCarrera, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbCarreras Find(int? id)
        {
            tbCarreras result = new tbCarreras();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@carr_Id", id);
                result = db.QueryFirst<tbCarreras>(ScriptsDataBase.BuscarCarrera, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbCarreras item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@carr_DescripcionCarrera", item.carr_DescripcionCarrera);
                parameter.Add("@carr_UsuarioCreacion", item.carr_UsuarioCreacion);
                parameter.Add("@carr_FechaCreacion", item.carr_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarCarrera, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbCarreras> List()
        {
            List<tbCarreras> result = new List<tbCarreras>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbCarreras>(ScriptsDataBase.ListarCarreras, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbCarreras item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@carr_Id", item.carr_Id);
                parameter.Add("@carr_DescripcionCarrera", item.carr_DescripcionCarrera);
                parameter.Add("@carr_UsuarioCreacion", item.carr_UsuarioCreacion);
                parameter.Add("@carr_FechaCreacion", item.carr_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarCarrera, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

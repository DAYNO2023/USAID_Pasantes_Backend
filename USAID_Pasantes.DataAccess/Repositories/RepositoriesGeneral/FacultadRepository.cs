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
    public class FacultadRepository : IRepository<tbFacultades>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@facu_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarFacultad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbFacultades Find(int? id)
        {
            tbFacultades result = new tbFacultades();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@facu_Id", id);
                result = db.QueryFirst<tbFacultades>(ScriptsDataBase.BuscarFacultad, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbFacultades item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@facu_DesripcionFacultad", item.facu_DesripcionFacultad);
                parameter.Add("@facu_UsuarioCreacion", item.facu_UsuarioCreacion);
                parameter.Add("@facu_FechaCreacion", item.facu_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarFacultad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbFacultades> List()
        {
            List<tbFacultades> result = new List<tbFacultades>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbFacultades>(ScriptsDataBase.ListarFacultades, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbFacultades item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@facu_Id", item.facu_Id);
                parameter.Add("@facu_DesripcionFacultad", item.facu_DesripcionFacultad);
                parameter.Add("@facu_UsuarioCreacion", item.facu_UsuarioCreacion);
                parameter.Add("@facu_FechaCreacion", item.facu_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarFacultad, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

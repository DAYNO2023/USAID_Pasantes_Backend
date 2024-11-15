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
    public class EmpleadoRepository : IRepository<tbEmpleados>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@empl_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarEmpleado, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbEmpleados Find(int? id)
        {
            tbEmpleados result = new tbEmpleados();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@empl_Id", id);
                result = db.QueryFirst<tbEmpleados>(ScriptsDataBase.BuscarEmpleado, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbEmpleados item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@empl_Imagen", item.empl_Imagen);
                parameter.Add("@empl_Nombres", item.empl_Nombres);
                parameter.Add("@empl_Apellidos", item.empl_Apellidos);
                parameter.Add("@empl_DNI", item.empl_DNI);
                parameter.Add("@empl_Correo", item.empl_Correo);
                parameter.Add("@empl_Sexo", item.empl_Sexo);
                parameter.Add("@empl_EsContador", item.empl_EsContador);
                parameter.Add("@empl_Telefono", item.empl_Telefono);
                parameter.Add("@civi_Id", item.civi_Id);
                parameter.Add("@empl_UsuarioCreacion", item.empl_UsuarioCreacion);
                parameter.Add("@empl_FechaCreacion", item.empl_FechaCreacion);
                

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarEmpleado, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbEmpleados> List()
        {
            List<tbEmpleados> result = new List<tbEmpleados>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbEmpleados>(ScriptsDataBase.ListarEmpleados, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbEmpleados item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@empl_Id", item.empl_Id);
                parameter.Add("@empl_Imagen", item.empl_Imagen);
                parameter.Add("@empl_Nombres", item.empl_Nombres);
                parameter.Add("@empl_Apellidos", item.empl_Apellidos);
                parameter.Add("@empl_DNI", item.empl_DNI);
                parameter.Add("@empl_Correo", item.empl_Correo);
                parameter.Add("@empl_Sexo", item.empl_Sexo);
                parameter.Add("@empl_EsContador", item.empl_EsContador);
                parameter.Add("@empl_Telefono", item.empl_Telefono);
                parameter.Add("@civi_Id", item.civi_Id);
                parameter.Add("@empl_UsuarioModificacion", item.empl_UsuarioModificacion);
                parameter.Add("@empl_FechaModificacion", item.empl_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarEmpleado, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

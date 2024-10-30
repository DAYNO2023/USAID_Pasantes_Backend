using Dapper;
using Microsoft.Data.SqlClient;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral
{
    public class EstadoCivilRepository : IRepository<tbEstadosCiviles>
    {
        /// <summary>
        /// Obtiene una lista de todos los estados civiles.
        /// </summary>
        /// <returns>Lista de estados civiles disponibles.</returns>
        public virtual IEnumerable<tbEstadosCiviles> List()
        {
            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbEstadosCiviles>(ScriptsDataBase.ListarEstadosCiviles, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        /// <summary>
        /// Busca un estado civil por su ID.
        /// </summary>
        /// <param name="id">El ID del estado civil que se desea buscar.</param>
        /// <returns>El estado civil encontrado.</returns>
        public tbEstadosCiviles Find(int? id)
        {
            tbEstadosCiviles result = new tbEstadosCiviles();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_Id", id);
                result = db.QueryFirst<tbEstadosCiviles>(ScriptsDataBase.BuscarEstadoCivil, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        /// <summary>
        /// Inserta un nuevo estado civil en la base de datos.
        /// </summary>
        /// <param name="item">Los detalles del estdo civil que se desea agregar.</param>
        /// <returns>El estado de la operación de inserción.</returns>
        public virtual RequestStatus Insert(tbEstadosCiviles item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_DescripcionEstadoCivil", item.civi_DescripcionEstadoCivil);
                parameter.Add("@civi_UsuarioCreacion", item.civi_UsuarioCreacion);
                parameter.Add("@civi_FechaCreacion", item.civi_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarEstadoCivil, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Actualiza la información de un estado civil existente.
        /// </summary>
        /// <param name="item">El objeto con la información actualizada del estado civil.</param>
        /// <returns>El estado de la operación de actualización.</returns>
        public virtual RequestStatus Update(tbEstadosCiviles item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                // Definición de los parámetros para el procedimiento almacenado.
                var parameter = new DynamicParameters();
                parameter.Add("@civi_Id", item.civi_Id);
                parameter.Add("@civi_DescripcionEstadoCivil", item.civi_DescripcionEstadoCivil);
                parameter.Add("@civi_UsuarioModificacion", item.civi_UsuarioModificacion);
                parameter.Add("@civi_FechaModificacion", item.civi_FechaModificacion);

                // Ejecución del procedimiento almacenado para actualizar el proceso de venta.
                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarEstadoCivil, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Elimina un estado civil usando su ID.
        /// </summary>
        /// <param name="id">El ID del estado civil que se desea eliminar.</param>
        /// <returns>El estado de la operación de eliminación.</returns>
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarEstadoCivil, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }



    }
}

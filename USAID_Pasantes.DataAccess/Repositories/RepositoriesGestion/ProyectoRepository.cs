using Dapper;
using Microsoft.Data.SqlClient;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion
{
    public class ProyectoRepository : IRepository<tbProyectos>
    {
        /// <summary>
        /// Obtiene una lista de todos los proyectos.
        /// </summary>
        /// <returns>Lista de proyectos disponibles.</returns>
        public virtual IEnumerable<tbProyectos> List()
        {
            List<tbProyectos> result = new List<tbProyectos>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbProyectos>(ScriptsDataBase.ListarProyectos, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        /// <summary>
        /// Busca un proyecto por su ID.
        /// </summary>
        /// <param name="id">El ID del proyecto que se desea buscar.</param>
        /// <returns>El proyecto encontrado.</returns>
        public tbProyectos Find(int? id)
        {
            tbProyectos result = new tbProyectos();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pryt_Id", id);
                result = db.QueryFirst<tbProyectos>(ScriptsDataBase.BuscarProyecto, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        /// <summary>
        /// Inserta un nuevo proyecto en la base de datos.
        /// </summary>
        /// <param name="item">Los detalles del proyecto que se desea agregar.</param>
        /// <returns>El estado de la operación de inserción.</returns>
        public virtual RequestStatus Insert(tbProyectos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pryt_DescripcionProyecto", item.pryt_DescripcionProyecto);
                parameter.Add("@pryt_HorasProceso", item.pryt_HorasProceso);
                parameter.Add("@empr_Id", item.empr_Id);
                parameter.Add("@pryt_UsuarioCreacion", item.pryt_UsuarioCreacion);
                parameter.Add("@pryt_FechaCreacion", item.pryt_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarProyecto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Actualiza la información de un proyecto existente.
        /// </summary>
        /// <param name="item">El objeto con la información actualizada del proyecto.</param>
        /// <returns>El estado de la operación de actualización.</returns>
        public virtual RequestStatus Update(tbProyectos item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pryt_Id", item.pryt_Id);
                parameter.Add("@pryt_DescripcionProyecto", item.pryt_DescripcionProyecto);
                parameter.Add("@pryt_HorasProceso", item.pryt_HorasProceso);
                parameter.Add("@empr_Id", item.empr_Id);
                parameter.Add("@pryt_UsuarioModificacion", item.pryt_UsuarioModificacion);
                parameter.Add("@pryt_FechaModificacion", item.pryt_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarProyecto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Elimina un proyecto usando su ID.
        /// </summary>
        /// <param name="id">El ID del proyecto que se desea eliminar.</param>
        /// <returns>El estado de la operación de eliminación.</returns>
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@pryt_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarProyecto, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

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
    public class BeneficioRepository : IRepository<tbBeneficios>
    {
        /// <summary>
        /// Obtiene una lista de todos los beneficios.
        /// </summary>
        /// <returns>Lista de beneficios disponibles.</returns>
        public virtual IEnumerable<tbBeneficios> List()
        {
            List<tbBeneficios> result = new List<tbBeneficios>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbBeneficios>(ScriptsDataBase.ListarBeneficios, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        /// <summary>
        /// Busca un beneficio por su ID.
        /// </summary>
        /// <param name="id">El ID del beneficio que se desea buscar.</param>
        /// <returns>El beneficio encontrado.</returns>
        public tbBeneficios Find(int? id)
        {
            tbBeneficios result = new tbBeneficios();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@bene_Id", id);
                result = db.QueryFirst<tbBeneficios>(ScriptsDataBase.BuscarBeneficio, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        /// <summary>
        /// Inserta un nuevo beneficio en la base de datos.
        /// </summary>
        /// <param name="item">Los detalles del beneficio que se desea agregar.</param>
        /// <returns>El estado de la operación de inserción.</returns>
        public virtual RequestStatus Insert(tbBeneficios item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@bene_NombreBeneficio", item.bene_NombreBeneficio);
                parameter.Add("@bene_DescripcionBeneficio", item.bene_DescripcionBeneficio);
                parameter.Add("@bene_Cantidad", item.bene_Cantidad);
                parameter.Add("@bene_UsuarioCreacion", item.bene_UsuarioCreacion);
                parameter.Add("@bene_FechaCreacion", item.bene_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarBeneficio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Actualiza la información de un beneficio existente.
        /// </summary>
        /// <param name="item">El objeto con la información actualizada del beneficio.</param>
        /// <returns>El estado de la operación de actualización.</returns>
        public virtual RequestStatus Update(tbBeneficios item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@bene_Id", item.bene_Id);
                parameter.Add("@bene_NombreBeneficio", item.bene_NombreBeneficio);
                parameter.Add("@bene_DescripcionBeneficio", item.bene_DescripcionBeneficio);
                parameter.Add("@bene_Cantidad", item.bene_Cantidad);
                parameter.Add("@bene_UsuarioModificacion", item.bene_UsuarioModificacion);
                parameter.Add("@bene_FechaModificacion", item.bene_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarBeneficio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Elimina un beneficio usando su ID.
        /// </summary>
        /// <param name="id">El ID del beneficio que se desea eliminar.</param>
        /// <returns>El estado de la operación de eliminación.</returns>
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@bene_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarBeneficio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

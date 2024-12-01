using Dapper;
using Microsoft.Data.SqlClient;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Common.Models.ModelsAcceso;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion
{
    public class OptanteRepository : IRepository<tbOptantes>
    {
        /// <summary>
        /// Obtiene una lista de todos los optantes.
        /// </summary>
        /// <returns>Lista de optantes disponibles.</returns>
        public virtual IEnumerable<tbOptantes> List()
        {
            List<tbOptantes> result = new List<tbOptantes>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbOptantes>(ScriptsDataBase.ListarOptantes, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        /// <summary>
        /// Registra un nuevo optante en la base de datos.
        /// </summary>
        /// <param name="item">Los detalles del optante que se desea agregar.</param>
        /// <returns>El estado de la operación de inserción.</returns>
        public virtual RequestStatus Register(tbOptantes item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                try
                {
                    var parameter = new DynamicParameters();
                    parameter.Add("@opta_Imagen", item.opta_Imagen);
                    parameter.Add("@opta_DNI", item.opta_DNI);
                    parameter.Add("@opta_Nombres", item.opta_Nombres);
                    parameter.Add("@opta_Apellidos", item.opta_Apellidos);
                    parameter.Add("@opta_FechaNacimiento", item.opta_FechaNacimiento);
                    parameter.Add("@opta_Sexo", item.opta_Sexo);
                    parameter.Add("@opta_Direccion", item.opta_Direccion);
                    parameter.Add("@opta_CorreoElectronico", item.opta_CorreoElectronico);
                    parameter.Add("@opta_Telefono1", item.opta_Telefono1);
                    parameter.Add("@opta_Telefono2", item.opta_Telefono2);
                    parameter.Add("@civi_Id", item.civi_Id);
                    parameter.Add("@tisa_Id", item.tisa_Id);
                    parameter.Add("@muni_Id", item.muni_Id);
                    parameter.Add("@cafr_Id", item.cafr_Id);

                    // Llama al procedimiento almacenado y captura los resultados
                    var resultData = db.QueryFirstOrDefault<dynamic>(
                        ScriptsDataBase.RegistrarOptante, // Nombre del procedimiento almacenado
                        parameter,
                        commandType: CommandType.StoredProcedure
                    );

                    // Verifica si el procedimiento almacenado retornó datos
                    if (resultData != null)
                    {
                        result.CodeStatus = 1;
                        result.Data = new CredencialesOptantes
                        {
                            Usuario = resultData.Usuario,
                            Contraseña = resultData.Contraseña
                        };
                    }
                    else
                    {
                        result.CodeStatus = 0;
                        result.Message = "Error al registrar el optante.";
                    }
                }
                catch (Exception ex)
                {
                    result.CodeStatus = 0;
                    result.Message = $"Error al ejecutar el procedimiento: {ex.Message}";
                }

                return result;
            }
        }


        /// <summary>
        /// Busca un optante por su ID.
        /// </summary>
        /// <param name="id">El ID del optante que se desea buscar.</param>
        /// <returns>El optante encontrado.</returns>
        public tbOptantes Find(int? id)
        {
            tbOptantes result = new tbOptantes();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@opta_Id", id);
                result = db.QueryFirst<tbOptantes>(ScriptsDataBase.BuscarOptante, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        /// <summary>
        /// Inserta un nuevo optante en la base de datos.
        /// </summary>
        /// <param name="item">Los detalles del optante que se desea agregar.</param>
        /// <returns>El estado de la operación de inserción.</returns>
        public virtual RequestStatus Insert(tbOptantes item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_DescripcionEstadoCivil", item.opta_DNI);
                parameter.Add("@civi_UsuarioCreacion", item.opta_UsuarioCreacion);
                parameter.Add("@civi_FechaCreacion", item.opta_FechaCreacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarOptante, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Actualiza la información de un optante existente.
        /// </summary>
        /// <param name="item">El objeto con la información actualizada del optante.</param>
        /// <returns>El estado de la operación de actualización.</returns>
        public virtual RequestStatus Update(tbOptantes item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@civi_Id", item.civi_Id);
                parameter.Add("@civi_DescripcionEstadoCivil", item.opta_DNI);
                parameter.Add("@civi_UsuarioModificacion", item.opta_UsuarioModificacion);
                parameter.Add("@civi_FechaModificacion", item.opta_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarOptante, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        /// <summary>
        /// Elimina un optante usando su ID.
        /// </summary>
        /// <param name="id">El ID del optante que se desea eliminar.</param>
        /// <returns>El estado de la operación de eliminación.</returns>
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@opta_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarOptante, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}

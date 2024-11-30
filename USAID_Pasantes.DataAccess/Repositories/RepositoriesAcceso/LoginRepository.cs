
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Common.Models.ModelsAcceso;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso
{
    public class LoginRepository : IRepository<tbUsuarios>
    {
        public object IniciarSesion(string usuario, string clave)
        {
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@usua_usario", usuario);
                parameters.Add("@usua_clave", clave);

                try
                {
                    using (var multi = db.QueryMultiple(ScriptsDataBase.IniciarSesion, parameters, commandType: CommandType.StoredProcedure))
                    {
                        Console.WriteLine("Reading user data...");
                        var usuarioData = multi.Read<UsuarioViewModel>().FirstOrDefault();
                        if (usuarioData == null)
                        {
                            Console.WriteLine("Usuario no encontrado.");
                            return null;
                        }
                        Console.WriteLine("User data read successfully.");

                        List<dynamic> optanteData = new List<dynamic>();
                        if (!multi.IsConsumed)
                        {
                            Console.WriteLine("Reading optant data...");
                            optanteData = multi.Read<dynamic>().ToList();
                            Console.WriteLine($"Optante Data Count: {optanteData.Count}");
                        }

                        // Reading modules data if applicable
                        List<dynamic> modulos = new List<dynamic>();
                        if (!multi.IsConsumed)
                        {
                            Console.WriteLine("Reading modules...");
                            modulos = multi.Read<dynamic>().ToList();
                            Console.WriteLine($"Modulos Count: {modulos.Count}");
                        }

                        // Combine and return the data
                        return new
                        {
                            Usuario = usuarioData,
                            Optante = optanteData.Any() ? optanteData : null,
                            Modulos = modulos
                        };
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error SQL: " + ex.Message);
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error General: " + ex.Message);
                    throw new Exception("Error General: " + ex.Message);
                }
            }
        }
        public RequestStatus InsertarCodigoVerificacion(int usua_Id)
        {
            // Creamos un objeto RequestStatus para almacenar el resultado de la operación
            RequestStatus result = new RequestStatus();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                // Creamos un objeto DynamicParameters para los parámetros del procedimiento almacenado
                var parameter = new DynamicParameters();
                parameter.Add("@usua_Id", usua_Id);

                parameter.Add("@UltimoCodigo", dbType: DbType.Int32, size: 100, direction: ParameterDirection.Output);
                var ansewer = db.Query(ScriptsDataBase.InsertarCodigoVerificacion, parameter, commandType: CommandType.StoredProcedure);
                int ultimoID = parameter.Get<int>("UltimoCodigo");

                var saber = ansewer.Select(ans =>
                {
                    return ans;

                }).ToList();

                result.CodeStatus = saber.Count;
                result.Message = ultimoID.ToString();

                return result;
            }
        }

        public RequestStatus VeirifarCodigoReestablecer(int usua_Id, int codigo)
        {
            // Creamos un objeto RequestStatus para almacenar el resultado de la operación
            RequestStatus result = new RequestStatus();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                // Creamos un objeto DynamicParameters para los parámetros del procedimiento almacenado
                var parameter = new DynamicParameters();
                parameter.Add("@usua_Id", usua_Id);
                parameter.Add("@usua_clave", codigo);

                var ansewer = db.Query(ScriptsDataBase.VerificarCodigoReestablecer, parameter, commandType: CommandType.StoredProcedure);

                var saber = ansewer.Select(ans =>
                {
                    return ans;

                }).ToList();

                result.CodeStatus = saber.Count;

                return result;
            }
        }
        public tbUsuarios Find(int? id)
        {
            tbUsuarios result = new tbUsuarios();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@usua_Id", id);
                result = db.QueryFirst<tbUsuarios>(ScriptsDataBase.Buscar_Usuario, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Reestablecer(tbUsuarios item)
        {
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@usua_Id", item.usua_Id);
                parametro.Add("@usua_clave", item.usua_Clave);

                var result = db.QueryFirst<int>(ScriptsDataBase.Reestablecer_Usuario,
                    parametro,
                     commandType: CommandType.StoredProcedure
                    );

                string mensaje = result > 0 ? "Exito" : result == 0 ? "Id no encontrado" : "Error";

                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }
        }

        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }



        public RequestStatus Insert(tbUsuarios item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbUsuarios> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbUsuarios item)
        {
            throw new NotImplementedException();
        }
    }
}

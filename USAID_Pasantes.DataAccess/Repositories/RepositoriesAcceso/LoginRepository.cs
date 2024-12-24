
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
                        var usuarioData = multi.Read<UsuarioViewModel>().FirstOrDefault();

                        if (usuarioData == null)
                        {
                            return null; // Usuario no encontrado
                        }

                        var optanteData = multi.IsConsumed ? null : multi.Read<dynamic>().ToList();
                        var modulos = multi.IsConsumed ? null : multi.Read<dynamic>().ToList();

                        return new
                        {
                            Usuario = usuarioData,
                            Optante_o_empleado = optanteData,
                            Modulos = modulos
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
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

        //Si lees estoy lo voy a dejar haci porque no quiero crear otro ViewModel difernte solo para capturar el correo 
        public class UsuarioRestablecerViewModel
        {
            public int UsuaId { get; set; }
            public string UsuaUsuario { get; set; }
            public bool UsuaEsOptante { get; set; }
            public int RelacionadoId { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
        }

        public UsuarioRestablecerViewModel BuscarUsuario(string? IdUsuario)
        {
            UsuarioRestablecerViewModel result = new UsuarioRestablecerViewModel();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@usua_Usuario", IdUsuario);
                result = db.QueryFirstOrDefault<UsuarioRestablecerViewModel>(
                    ScriptsDataBase.Buscar_UsuarioRestablecer,
                    parameter,
                    commandType: CommandType.StoredProcedure
                );
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesAcceso
{
    public class LoginService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly LoginRepository _loginRepository;

        // Constructor que inicializa el repositorio.
        public LoginService(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public ServiceResult IniciarSesion(string usuario, string clave)
        {
            try
            {
                var userSessionData = _loginRepository.IniciarSesion(usuario, clave);

                if (userSessionData == null)
                {
                    return new ServiceResult().Unauthorized("Usuario o contraseña incorrectos, o el usuario está inactivo.");
                }

                return new ServiceResult().Ok("Inicio de sesión exitoso.", userSessionData);
            }
            catch (Exception ex)
            {
                return new ServiceResult().Error($"Error al iniciar sesión: {ex.Message}");
            }
        }


        public ServiceResult InsertarCodigoRestablecer(int usua_Id)
        {
            var result = new ServiceResult();

            try
            {
                var request = _loginRepository.InsertarCodigoVerificacion(usua_Id);

                if (request.CodeStatus == 2)
                {
                    return result.Ok(request);
                }
                else
                {
                    return result.Error(request);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult VerificarCodigoReestablecer(int usua_Id, int codigo)
        {
            var result = new ServiceResult();

            try
            {
                var request = _loginRepository.VeirifarCodigoReestablecer(usua_Id, codigo);

                if (request.CodeStatus == 1)
                {
                    return result.Ok(request);
                }
                else
                {
                    return result.Error(request);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Buscar(int? id)
        {
            var result = new ServiceResult();

            try
            {
                var usuario = _loginRepository.Find(id);

                return result.Ok(usuario);
            }
            catch (Exception ex)
            {
                result.Error(ex.Message);

                throw;
            }
        }

        public ServiceResult BuscarUsuario(string? IdUsuario)
        {
            var result = new ServiceResult();

            try
            {
                var usuario = _loginRepository.BuscarUsuario(IdUsuario);

                return result.Ok(usuario);
            }
            catch (Exception ex)
            {
                result.Error(ex.Message);

                throw;
            }
        }

        public ServiceResult ReestablecerUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();

            try
            {
                var request = _loginRepository.Reestablecer(item);

                return request.CodeStatus > 0 ? result.Ok(request) : result.Error(request);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


    }
}

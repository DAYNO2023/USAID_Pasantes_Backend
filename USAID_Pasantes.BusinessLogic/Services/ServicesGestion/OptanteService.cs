using USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Common.Models.ModelsAcceso;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGestion
{
    public class OptanteService
    {
        private readonly OptanteRepository _optanteRepository;

        /// <summary>
        /// Constructor del servicio de optante que inicializa el repositorio de optantes.
        /// </summary>
        /// <param name="optanteRepository">Instancia del repositorio de optantes.</param>
        public OptanteService(OptanteRepository optanteRepository)
        {
            _optanteRepository = optanteRepository;
        }

        /// <summary>
        /// Obtiene una lista de todos los optantes.
        /// </summary>
        /// <returns>Resultado de la operación con la lista de optantes.</returns>
        public ServiceResult ListarOptantes()
        {
            var result = new ServiceResult();
            try
            {
                var list = _optanteRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        /// <summary>
        /// Rrgistra un nuevo optante en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los detalles del optante a registrar.</param>
        /// <returns>Resultado de la operación de registro con el estado de la operación.</returns>
        public ServiceResult RegistrarOptante(tbOptantes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _optanteRepository.Register(item);

                // Evaluamos el resultado del servicio
                if (map.CodeStatus == 1)
                {
                    // Caso de éxito: retorna credenciales generadas junto con success = 1
                    var data = (CredencialesOptantes)map.Data;
                    return result.Ok(new
                    {
                        success = 1,
                        Usuario = data.Usuario,
                        Contraseña = data.Contraseña
                    });
                }
                else if (map.CodeStatus == 2)
                {
                    // Caso de error: DNI ya registrado, respondemos con código 501 y success = 2
                    return result.BadRequest(new
                    {
                        success = 2,
                        message = "DNI ya registrado."
                    });
                }
                else if (map.CodeStatus == 3)
                {
                    // Caso de error: correo ya registrado, respondemos con código 501 y success = 3
                    return result.BadRequest(new
                    {
                        
                        success = 3,
                        message = "Correo ya registrado."
                    });
                }
                else
                {
                    // Caso de error inesperado, success = 0
                    return result.Ok(new
                    {
                        success = 0,
                        message = "Error desconocido al registrar el optante."
                    });
                }
            }
            catch (Exception ex)
            {
                // Caso de excepción, success = 0
                return result.Error(new
                {
                    success = 0,
                    message = $"Error al registrar el optante: {ex.Message}"
                });
            }
        }


        /// <summary>
        /// Busca un optante por su ID.
        /// </summary>
        /// <param name="id">ID del optante a buscar.</param>
        /// <returns>Resultado de la operación con el optante encontrado.</returns>
        public ServiceResult BuscarOptante(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _optanteRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Inserta un nuevo optante en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los detalles del optante a insertar.</param>
        /// <returns>Resultado de la operación de inserción con el estado de la operación.</returns>
        public ServiceResult InsertarOptante(tbOptantes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _optanteRepository.Insert(item);
                if (map.CodeStatus >= 1)
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los datos de un optante existente en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los datos actualizados del optante.</param>
        /// <returns>Resultado de la operación de actualización con el estado de la operación.</returns>
        public ServiceResult ActualizarOptante(tbOptantes item)
        {

            var result = new ServiceResult();
            try
            {
                var map = _optanteRepository.Update(item);
                if (map.CodeStatus >= 1)
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Elimina un optante de la base de datos usando su ID.
        /// </summary>
        /// <param name="id">ID del optante a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación con el estado de la operación.</returns>
        public ServiceResult EliminarOptante(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _optanteRepository.Delete(id);
                if (map.CodeStatus >= 1)
                {
                    return result.Ok(map);
                }
                else
                {
                    return result.Error(map);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
    }
}

using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class EstadoCivilService
    {
        private readonly EstadoCivilRepository _estadocivilRepository;

        /// <summary>
        /// Constructor del servicio de estado civil que inicializa el repositorio de estados civiles.
        /// </summary>
        /// <param name="estadocivilRepository">Instancia del repositorio de estados civiles.</param>
        public EstadoCivilService(EstadoCivilRepository estadocivilRepository)
        {
            _estadocivilRepository = estadocivilRepository;
        }

        /// <summary>
        /// Obtiene una lista de todos los estados civiles.
        /// </summary>
        /// <returns>Resultado de la operación con la lista de estados civiles.</returns>
        public ServiceResult ListarEstadosCiviles()
        {
            var result = new ServiceResult();
            try
            {
                var list = _estadocivilRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Busca un estado civil por su ID.
        /// </summary>
        /// <param name="id">ID del estado civil a buscar.</param>
        /// <returns>Resultado de la operación con el estado civil encontrado.</returns>
        public ServiceResult BuscarEstadoCivil(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadocivilRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Inserta un nuevo estado civil en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los detalles del estado civil a insertar.</param>
        /// <returns>Resultado de la operación de inserción con el estado de la operación.</returns>
        public ServiceResult InsertarEstadoCivil(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadocivilRepository.Insert(item);
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
        /// Actualiza los datos de un estado civil existente en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los datos actualizados del estado civil.</param>
        /// <returns>Resultado de la operación de actualización con el estado de la operación.</returns>
        public ServiceResult ActualizarEstadoCivil(tbEstadosCiviles item)
        {

            var result = new ServiceResult();
            try
            {
                var map = _estadocivilRepository.Update(item);
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
        /// Elimina un estado civil de la base de datos usando su ID.
        /// </summary>
        /// <param name="id">ID del estado civil a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación con el estado de la operación.</returns>
        public ServiceResult EliminarEstadoCivil(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _estadocivilRepository.Delete(id);
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

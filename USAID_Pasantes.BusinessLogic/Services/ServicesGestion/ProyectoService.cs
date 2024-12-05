using USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGestion
{
    public class ProyectoService
    {
        private readonly ProyectoRepository _proyectoRepository;

        /// <summary>
        /// Constructor del servicio de proyecto que inicializa el repositorio de proyectos.
        /// </summary>
        /// <param name="proyectoRepository">Instancia del repositorio de proyectos.</param>
        public ProyectoService(ProyectoRepository proyectoRepository)
        {
            _proyectoRepository = proyectoRepository;
        }

        /// <summary>
        /// Obtiene una lista de todos los proyectos.
        /// </summary>
        /// <returns>Resultado de la operación con la lista de proyectos.</returns>
        public ServiceResult ListarProyectos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _proyectoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Busca un proyecto por su ID.
        /// </summary>
        /// <param name="id">ID del proyecto a buscar.</param>
        /// <returns>Resultado de la operación con el proyecto encontrado.</returns>
        public ServiceResult BuscarProyecto(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _proyectoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Inserta un nuevo proyecto en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los detalles del proyecto a insertar.</param>
        /// <returns>Resultado de la operación de inserción con el estado de la operación.</returns>
        public ServiceResult InsertarProyecto(tbProyectos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _proyectoRepository.Insert(item);
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
        /// Actualiza los datos de un proyecto existente en la base de datos.
        /// </summary>
        /// <param name="item">Entidad con los datos actualizados del proyecto.</param>
        /// <returns>Resultado de la operación de actualización con el estado de la operación.</returns>
        public ServiceResult ActualizarProyecto(tbProyectos item)
        {

            var result = new ServiceResult();
            try
            {
                var map = _proyectoRepository.Update(item);
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
        /// Elimina un proyecto de la base de datos usando su ID.
        /// </summary>
        /// <param name="id">ID del proyecto a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación con el estado de la operación.</returns>
        public ServiceResult EliminarProyecto(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _proyectoRepository.Delete(id);
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

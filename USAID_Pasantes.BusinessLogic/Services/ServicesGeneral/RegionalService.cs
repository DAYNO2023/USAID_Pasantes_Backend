using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class RegionalService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly RegionalRepository _regionalRepository;

        // Constructor que inicializa el repositorio.
        public RegionalService(RegionalRepository regionalRepository)
        {
            _regionalRepository = regionalRepository;
        }
        public ServiceResult ListarRegionales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _regionalRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene una lista de todas las regionales por la universidad seleccionada.
        /// </summary>
        /// <returns>Resultado de la operación con la lista de regionales.</returns>
        public ServiceResult ListarRegionalesPorUniversidad(int id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _regionalRepository.ListByUniversity(id);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRegional(tbRegionales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalRepository.Insert(item);
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

        public ServiceResult ActualizarRegional(tbRegionales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalRepository.Update(item);
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

        public ServiceResult EliminarRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalRepository.Delete(id);
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

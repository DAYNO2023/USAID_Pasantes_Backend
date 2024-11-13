using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class UniversidadService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly UniversidadRepository _universidadRepository;

        // Constructor que inicializa el repositorio.
        public UniversidadService(UniversidadRepository universidadRepository)
        {
            _universidadRepository = universidadRepository;
        }
        public ServiceResult ListarUniversidades()
        {
            var result = new ServiceResult();
            try
            {
                var list = _universidadRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarUniversidad(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _universidadRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarUniversidad(tbUniversidades item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _universidadRepository.Insert(item);
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

        public ServiceResult ActualizarUniversidad(tbUniversidades item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _universidadRepository.Update(item);
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

        public ServiceResult EliminarUniversidad(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _universidadRepository.Delete(id);
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

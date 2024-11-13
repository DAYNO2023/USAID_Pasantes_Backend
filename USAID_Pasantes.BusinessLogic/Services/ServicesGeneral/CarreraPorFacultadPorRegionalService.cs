using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class CarreraPorFacultadPorRegionalService
    {

        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly CarreraPorFacultadPorRegionalRepository _carreraPorFacultadPorRegionalRepository;

        // Constructor que inicializa el repositorio.
        public CarreraPorFacultadPorRegionalService(CarreraPorFacultadPorRegionalRepository carreraPorFacultadPorRegionalRepository)
        {
            _carreraPorFacultadPorRegionalRepository = carreraPorFacultadPorRegionalRepository;
        }
        public ServiceResult ListarCarreraPorFacultadPorRegional()
        {
            var result = new ServiceResult();
            try
            {
                var list = _carreraPorFacultadPorRegionalRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarCarreraPorFacultadPorRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraPorFacultadPorRegionalRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCarreraPorFacultadPorRegional(tbCarreraPorFacultadPorRegional item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraPorFacultadPorRegionalRepository.Insert(item);
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

        public ServiceResult ActualizarCarreraPorFacultadPorRegional(tbCarreraPorFacultadPorRegional item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraPorFacultadPorRegionalRepository.Update(item);
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

        public ServiceResult EliminarCarreraPorFacultadPorRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraPorFacultadPorRegionalRepository.Delete(id);
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

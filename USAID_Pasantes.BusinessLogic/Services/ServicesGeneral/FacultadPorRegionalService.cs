using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class FacultadPorRegionalService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly FacultadPorRegionalRepository _facultadPorRegionalRepository;

        // Constructor que inicializa el repositorio.
        public FacultadPorRegionalService(FacultadPorRegionalRepository facultadPorRegionalRepository)
        {
            _facultadPorRegionalRepository = facultadPorRegionalRepository;
        }
        public ServiceResult ListarFacultadPorRegional()
        {
            var result = new ServiceResult();
            try
            {
                var list = _facultadPorRegionalRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarFacultadPorRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadPorRegionalRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFacultadPorRegional(tbFacultadPorRegional item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadPorRegionalRepository.Insert(item);
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

        public ServiceResult ActualizarFacultadPorRegional(tbFacultadPorRegional item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadPorRegionalRepository.Update(item);
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

        public ServiceResult EliminarFacultadPorRegional(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadPorRegionalRepository.Delete(id);
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

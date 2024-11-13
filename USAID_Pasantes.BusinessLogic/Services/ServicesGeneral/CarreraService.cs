using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class CarreraService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly CarreraRepository _carreraRepository;

        // Constructor que inicializa el repositorio.
        public CarreraService(CarreraRepository carreraRepository)
        {
            _carreraRepository = carreraRepository;
        }
        public ServiceResult ListarCarreras()
        {
            var result = new ServiceResult();
            try
            {
                var list = _carreraRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarCarrera(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarCarrera(tbCarreras item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraRepository.Insert(item);
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

        public ServiceResult ActualizarCarrera(tbCarreras item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraRepository.Update(item);
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

        public ServiceResult EliminarCarrera(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _carreraRepository.Delete(id);
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

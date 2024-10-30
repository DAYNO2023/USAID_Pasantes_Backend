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
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly EstadoCivilRepository _estadocivilRepository;

        // Constructor que inicializa el repositorio.
        public EstadoCivilService(EstadoCivilRepository estadocivilRepository)
        {
            _estadocivilRepository = estadocivilRepository;
        }
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

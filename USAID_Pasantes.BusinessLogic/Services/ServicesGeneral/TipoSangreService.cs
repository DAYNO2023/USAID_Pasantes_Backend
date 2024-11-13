using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class TipoSangreService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly TipoSangreRepository _tipoSangreRepository;

        // Constructor que inicializa el repositorio.
        public TipoSangreService(TipoSangreRepository tipoSangreRepository)
        {
            
            _tipoSangreRepository = tipoSangreRepository;
        }
        public ServiceResult ListarTipoSangres()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tipoSangreRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarTipoSangre(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoSangreRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoSangre(tbTipoSangre item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoSangreRepository.Insert(item);
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

        public ServiceResult ActualizarTipoSangre(tbTipoSangre item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoSangreRepository.Update(item);
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

        public ServiceResult EliminarTipoSangre(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoSangreRepository.Delete(id);
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

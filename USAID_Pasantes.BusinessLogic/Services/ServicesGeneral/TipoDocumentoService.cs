using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class TipoDocumentoService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly TipoDocumentoRepository _tipoDocumentoRepository;

        // Constructor que inicializa el repositorio.
        public TipoDocumentoService(TipoDocumentoRepository tipoDocumentoRepository)
        {
            _tipoDocumentoRepository = tipoDocumentoRepository;
        }
        public ServiceResult ListarTipoDocumentos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _tipoDocumentoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarTipoDocumento(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarTipoDocumento(tbTipoDocumento item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Insert(item);
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

        public ServiceResult ActualizarTipoDocumento(tbTipoDocumento item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Update(item);
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

        public ServiceResult EliminarTipoDocumento(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tipoDocumentoRepository.Delete(id);
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

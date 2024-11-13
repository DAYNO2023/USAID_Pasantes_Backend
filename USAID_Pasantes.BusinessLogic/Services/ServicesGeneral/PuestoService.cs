using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class PuestoService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly PuestoRepository _puestoRepository;

        // Constructor que inicializa el repositorio.
        public PuestoService(PuestoRepository puestoRepository)
        {
            _puestoRepository = puestoRepository;
        }
        public ServiceResult ListarPuestos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _puestoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarPuesto(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _puestoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPuesto(tbPuestos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _puestoRepository.Insert(item);
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

        public ServiceResult ActualizarPuesto(tbPuestos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _puestoRepository.Update(item);
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

        public ServiceResult EliminarPuesto(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _puestoRepository.Delete(id);
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

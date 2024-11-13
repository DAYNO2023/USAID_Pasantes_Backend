using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class DepartamentoService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly DepartamentoRepository _departamentoRepository;

        // Constructor que inicializa el repositorio.
        public DepartamentoService(DepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }
        public ServiceResult ListarDepartamentos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarDepartamento(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _departamentoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarDepartamento(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _departamentoRepository.Insert(item);
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

        public ServiceResult ActualizarDepartamento(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _departamentoRepository.Update(item);
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

        public ServiceResult EliminarDepartamento(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _departamentoRepository.Delete(id);
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

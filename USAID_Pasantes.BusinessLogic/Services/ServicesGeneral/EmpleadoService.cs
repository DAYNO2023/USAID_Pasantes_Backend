using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class EmpleadoService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly EmpleadoRepository _empleadoRepository;

        // Constructor que inicializa el repositorio.
        public EmpleadoService(EmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public ServiceResult ListarEmpleados()
        {
            var result = new ServiceResult();
            try
            {
                var list = _empleadoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarEmpleado(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarEmpleado(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadoRepository.Insert(item);
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

        public ServiceResult ActualizarEmpleado(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadoRepository.Update(item);
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

        public ServiceResult EliminarEmpleado(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _empleadoRepository.Delete(id);
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

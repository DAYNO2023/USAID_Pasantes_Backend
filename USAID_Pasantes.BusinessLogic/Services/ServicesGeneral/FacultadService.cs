using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class FacultadService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly FacultadRepository _facultadRepository;

        // Constructor que inicializa el repositorio.
        public FacultadService(FacultadRepository facultadRepository)
        {
            _facultadRepository = facultadRepository;
        }
        public ServiceResult ListarFacultades()
        {
            var result = new ServiceResult();
            try
            {
                var list = _facultadRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarFacultad(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarFacultad(tbFacultades item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadRepository.Insert(item);
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

        public ServiceResult ActualizarFacultad(tbFacultades item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadRepository.Update(item);
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

        public ServiceResult EliminarFacultad(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _facultadRepository.Delete(id);
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

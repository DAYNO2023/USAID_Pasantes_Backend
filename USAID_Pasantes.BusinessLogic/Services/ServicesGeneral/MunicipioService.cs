using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class MunicipioService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly MunicipioRepository _municipioRepository;

        // Constructor que inicializa el repositorio.
        public MunicipioService(MunicipioRepository municipioRepository)
        {
            _municipioRepository = municipioRepository;
        }
        public ServiceResult ListarMunicipios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _municipioRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarMunicipio(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _municipioRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarMunicipio(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _municipioRepository.Insert(item);
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

        public ServiceResult ActualizarMunicipio(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _municipioRepository.Update(item);
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

        public ServiceResult EliminarMunicipio(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _municipioRepository.Delete(id);
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

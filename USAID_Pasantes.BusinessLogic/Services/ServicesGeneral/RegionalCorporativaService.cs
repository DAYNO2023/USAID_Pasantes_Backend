using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class RegionalCorporativaService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly RegionalCorporativaRepository _regionalCorporativaRepository;

        // Constructor que inicializa el repositorio.
        public RegionalCorporativaService(RegionalCorporativaRepository regionalCorporativaRepository)
        {
            _regionalCorporativaRepository = regionalCorporativaRepository;
        }
        public ServiceResult ListarRegionalCorporativas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _regionalCorporativaRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarRegionalCorporativa(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalCorporativaRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRegionalCorporativa(tbRegionalCorporativa item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalCorporativaRepository.Insert(item);
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

        public ServiceResult ActualizarRegionalCorporativa(tbRegionalCorporativa item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalCorporativaRepository.Update(item);
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

        public ServiceResult EliminarRegionalCorporativa(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _regionalCorporativaRepository.Delete(id);
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

using USAID_Pasantes.DataAccess.Repositories.RepositoriesGestion;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGestion
{
    public class BeneficioService
    {
        private readonly BeneficioRepository _beneficioRepository;

        public BeneficioService(BeneficioRepository beneficioRepository)
        {
            _beneficioRepository = beneficioRepository;
        }
        public ServiceResult ListarBeneficios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _beneficioRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarBeneficio(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _beneficioRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarBeneficio(tbBeneficios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _beneficioRepository.Insert(item);
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

        public ServiceResult ActualizarBeneficio(tbBeneficios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _beneficioRepository.Update(item);
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

        public ServiceResult EliminarBeneficio(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _beneficioRepository.Delete(id);
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

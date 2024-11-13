using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesGeneral
{
    public class BancoService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly BancoRepository _bancoRepository;

        // Constructor que inicializa el repositorio.
        public BancoService(BancoRepository bancoRepository)
        {
            _bancoRepository = bancoRepository;
        }
        public ServiceResult ListarBancos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _bancoRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult BuscarBanco(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _bancoRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarBanco(tbBancos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _bancoRepository.Insert(item);
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

        public ServiceResult ActualizarBanco(tbBancos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _bancoRepository.Update(item);
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

        public ServiceResult EliminarBanco(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _bancoRepository.Delete(id);
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

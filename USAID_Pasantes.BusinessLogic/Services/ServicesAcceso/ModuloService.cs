using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesAcceso
{
    public class ModuloService
    {
        // Inyección de dependencias del repositorio para manejar procesos de venta e imágenes.
        private readonly ModuloRepository _moduloRepository;

        public ModuloService(ModuloRepository moduloRepository)
        {
            _moduloRepository = moduloRepository;
        }

        public ServiceResult ListarModulos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _moduloRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
    }
}

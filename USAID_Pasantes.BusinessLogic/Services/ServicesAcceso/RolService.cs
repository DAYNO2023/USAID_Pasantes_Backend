using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.BusinessLogic.Services.ServicesAcceso
{
    public class RolService
    {
        private readonly RolRepository _rolRepository;

        public RolService(RolRepository rolRepository)
        {
            _rolRepository = rolRepository;

        }
        public ServiceResult ListarRol()
        {
            var result = new ServiceResult();
            try
            {
                var list = _rolRepository.List();
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        public ServiceResult BuscarRol(int id)
        {
            var result = new ServiceResult();
            try
            {
                var map = _rolRepository.Find(id);
                return result.Ok(map);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        /// <summary>
        /// Inserta una nueva relación entre una pantalla y un rol en la base de datos.
        /// </summary>
        /// <param name="item">El objeto tbPantallasPorRoles que contiene los datos de la relación a insertar.</param>
        /// <returns>Un objeto ServiceResult que indica el resultado de la operación.</returns>
        public ServiceResult InsertarRol(tbRoles item)
        {
            var result = new ServiceResult();

            try
            {
                var map = _rolRepository.Insert(item);

                if (map.CodeStatus == 1)
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


        public ServiceResult ActualizarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _rolRepository.Update(item);
                if (map.CodeStatus == 1)
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

        /// <summary>
        /// Elimina la relación entre una pantalla y un rol específico en la base de datos.
        /// </summary>
        /// <param name="id">El ID de la relación a eliminar.</param>
        /// <returns>Un objeto ServiceResult que indica el resultado de la operación.</returns>
        public ServiceResult EliminarRol(int id)
        {
            var result = new ServiceResult();

            try
            {
                var map = _rolRepository.Delete(id);

                if (map.CodeStatus == 1)
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

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesAcceso;
using USAID_Pasantes.Common.Models.ModelsAcceso;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.API.Controllers.ControllersAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuloPorRolController : Controller
    {
        private readonly ModuloPorRolService _moduloPorRolService;
        private readonly IMapper _mapper;

        public ModuloPorRolController(ModuloPorRolService moduloPorRolService, IMapper mapper)
        {
            _moduloPorRolService = moduloPorRolService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult ListarModuloPorRol()
        {
            var response = _moduloPorRolService.ListarModulosPorRoles();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarPantallaPorRol(int id)
        {
            var response = _moduloPorRolService.BuscarModulosPorRol(id);
            return Ok(response.Data);
        }


        /// <summary>
        /// Inserta múltiples módulos asociados a un rol.
        /// </summary>
        /// <param name="moduloPorRolViewModel">El objeto que contiene el ID del rol y la lista de módulos.</param>
        /// <returns>Un resultado de la operación con un estado HTTP.</returns>
        [HttpPost("Insertar")]
        public virtual IActionResult Insertar(ModuloPorRolViewModel moduloPorRolViewModel)
        {
            try
            {
                var response = _moduloPorRolService.InsertarModulosPorRol(moduloPorRolViewModel);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        /// <summary>
        /// Actualiza los módulos asociados a un rol existente.
        /// </summary>
        /// <param name="moduloPorRolViewModel">El objeto que contiene el ID del rol y la lista actualizada de módulos.</param>
        /// <returns>Un resultado de la operación con un estado HTTP.</returns>
        [HttpPut("Actualizar")]
        public virtual IActionResult Actualizar(ModuloPorRolViewModel moduloPorRolViewModel)
        {
            try
            {
                var response = _moduloPorRolService.ActualizarModulosPorRol(moduloPorRolViewModel);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }


        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _moduloPorRolService.EliminarModulosPorRol(id);
            return Ok(response);
        }
    }
}

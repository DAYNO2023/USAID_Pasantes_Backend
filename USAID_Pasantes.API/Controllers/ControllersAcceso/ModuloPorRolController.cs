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



        [HttpPut("Actualizar")]
        public virtual IActionResult Update(ModuloPorRolViewModel ModuloPorRolViewModel)
        {
            var modelo = _mapper.Map<ModuloPorRolViewModel, tbModulosPorRoles>(ModuloPorRolViewModel);
            var response = _moduloPorRolService.ActualizarModulosPorRol(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _moduloPorRolService.EliminarModulosPorRol(id);
            return Ok(response);
        }
    }
}

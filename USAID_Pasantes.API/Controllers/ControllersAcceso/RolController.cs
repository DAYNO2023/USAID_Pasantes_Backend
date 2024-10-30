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
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : Controller
    {
        private readonly RolService _rolService;
        private readonly IMapper _mapper;

        public RolController(RolService rolService, IMapper mapper)
        {
            _mapper = mapper;
            _rolService = rolService;
        }

        [HttpGet("Listar")]
        public IActionResult ListarModuloPorRol()
        {
            var response = _rolService.ListarRol();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarPantallaPorRol(int id)
        {
            var response = _rolService.BuscarRol(id);
            return Ok(response.Data);
        }



        [HttpPost("Insertar")]
        public virtual IActionResult Create(RolViewModel rolViewModel)
        {
            var modelo = _mapper.Map<RolViewModel, tbRoles>(rolViewModel);
            var response = _rolService.InsertarRol(modelo);
            return Ok(response);
        }


        [HttpPut("Actualizar")]
        public virtual IActionResult Update(RolViewModel rolViewModel)
        {
            var modelo = _mapper.Map<RolViewModel, tbRoles>(rolViewModel);
            var response = _rolService.ActualizarRol(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _rolService.EliminarRol(id);
            return Ok(response);
        }
    }
}

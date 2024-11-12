using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesGeneral;
using USAID_Pasantes.Common.Models.ModelsGeneral;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.API.Controllers.ControllersGeneral
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversidadController : Controller
    {
        private readonly UniversidadService _universidadService;
        private readonly IMapper _mapper;
        public UniversidadController(UniversidadService universidadService, IMapper mapper)
        {
            _universidadService = universidadService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarUniversidades()
        {
            var response = _universidadService.ListarUniversidades();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarUniversidad(int id)
        {
            var response = _universidadService.BuscarUniversidad(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(UniversidadViewModel universidadViewModel)
        {
            var modelo = _mapper.Map<UniversidadViewModel, tbUniversidades>(universidadViewModel);
            var response = _universidadService.InsertarUniversidad(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(UniversidadViewModel universidadViewModel)
        {
            var modelo = _mapper.Map<UniversidadViewModel, tbUniversidades>(universidadViewModel);
            var response = _universidadService.ActualizarUniversidad(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _universidadService.EliminarUniversidad(id);
            return Ok(response);
        }
    }
}

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
    public class RegionalController : Controller
    {
        private readonly RegionalService _regionalService;
        private readonly IMapper _mapper;
        public RegionalController(RegionalService regionalService, IMapper mapper)
        {
            _regionalService = regionalService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarRegionales()
        {
            var response = _regionalService.ListarRegionales();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarRegional(int id)
        {
            var response = _regionalService.BuscarRegional(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(RegionalViewModel regionalViewModel)
        {
            var modelo = _mapper.Map<RegionalViewModel, tbRegionales>(regionalViewModel);
            var response = _regionalService.InsertarRegional(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(RegionalViewModel regionalViewModel)
        {
            var modelo = _mapper.Map<RegionalViewModel, tbRegionales>(regionalViewModel);
            var response = _regionalService.ActualizarRegional(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _regionalService.EliminarRegional(id);
            return Ok(response);
        }
    }
}

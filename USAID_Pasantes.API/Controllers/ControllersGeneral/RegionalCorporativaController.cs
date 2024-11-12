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
    public class RegionalCorporativaController : Controller
    {
        private readonly RegionalCorporativaService _regionalCorporativaService;
        private readonly IMapper _mapper;
        public RegionalCorporativaController(RegionalCorporativaService regionalCorporativaService, IMapper mapper)
        {
            _regionalCorporativaService = regionalCorporativaService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarRegionalCorporativa()
        {
            var response = _regionalCorporativaService.ListarRegionalCorporativas();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarRegionalCorporativa(int id)
        {
            var response = _regionalCorporativaService.BuscarRegionalCorporativa(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(RegionalCorporativaViewModel regionalCorporativaViewModel)
        {
            var modelo = _mapper.Map<RegionalCorporativaViewModel, tbRegionalCorporativa>(regionalCorporativaViewModel);
            var response = _regionalCorporativaService.InsertarRegionalCorporativa(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(RegionalCorporativaViewModel regionalCorporativaViewModel)
        {
            var modelo = _mapper.Map<RegionalCorporativaViewModel, tbRegionalCorporativa>(regionalCorporativaViewModel);
            var response = _regionalCorporativaService.ActualizarRegionalCorporativa(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _regionalCorporativaService.EliminarRegionalCorporativa(id);
            return Ok(response);
        }
    }
}

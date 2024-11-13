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
    public class CarreraPorFacultadPorRegionalController : Controller
    {
        private readonly CarreraPorFacultadPorRegionalService _carreraPorFacultadPorRegionalService;
        private readonly IMapper _mapper;
        public CarreraPorFacultadPorRegionalController(CarreraPorFacultadPorRegionalService carreraPorFacultadPorRegionalService, IMapper mapper)
        {
            _carreraPorFacultadPorRegionalService = carreraPorFacultadPorRegionalService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult ListarCarreraPorFacultadPorRegional()
        {
            var response = _carreraPorFacultadPorRegionalService.ListarCarreraPorFacultadPorRegional();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarCarreraPorFacultadPorRegional(int id)
        {
            var response = _carreraPorFacultadPorRegionalService.BuscarCarreraPorFacultadPorRegional(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(CarreraPorFacultadPorRegionalViewModel carreraPorFacultadPorRegionalViewModel)
        {
            var modelo = _mapper.Map<CarreraPorFacultadPorRegionalViewModel, tbCarreraPorFacultadPorRegional>(carreraPorFacultadPorRegionalViewModel);
            var response = _carreraPorFacultadPorRegionalService.InsertarCarreraPorFacultadPorRegional(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(CarreraPorFacultadPorRegionalViewModel carreraPorFacultadPorRegionalViewModel)
        {
            var modelo = _mapper.Map<CarreraPorFacultadPorRegionalViewModel, tbCarreraPorFacultadPorRegional>(carreraPorFacultadPorRegionalViewModel);
            var response = _carreraPorFacultadPorRegionalService.ActualizarCarreraPorFacultadPorRegional(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _carreraPorFacultadPorRegionalService.EliminarCarreraPorFacultadPorRegional(id);
            return Ok(response);
        }

    }
}

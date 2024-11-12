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
    public class CarreraController : Controller
    {
        private readonly CarreraService _carreraService;
        private readonly IMapper _mapper;
        public CarreraController(CarreraService carreraService, IMapper mapper)
        {
            _carreraService = carreraService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarCarreras()
        {
            var response = _carreraService.ListarCarreras();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarCarrera(int id)
        {
            var response = _carreraService.BuscarCarrera(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(CarreraViewModel carreraViewModel)
        {
            var modelo = _mapper.Map<CarreraViewModel, tbCarreras>(carreraViewModel);
            var response = _carreraService.InsertarCarrera(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(CarreraViewModel carreraViewModel)
        {
            var modelo = _mapper.Map<CarreraViewModel, tbCarreras>(carreraViewModel);
            var response = _carreraService.ActualizarCarrera(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _carreraService.EliminarCarrera(id);
            return Ok(response);
        }
    }
}

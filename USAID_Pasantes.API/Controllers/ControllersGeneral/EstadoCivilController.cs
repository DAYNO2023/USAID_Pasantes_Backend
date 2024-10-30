using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USAID_Pasantes.BusinessLogic.Services.ServicesGeneral;
using USAID_Pasantes.Common.Models.ModelsGeneral;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API.Controllers.ControllersGeneral
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCivilController : Controller
    {
        private readonly EstadoCivilService _estadocivilService;
        private readonly IMapper _mapper;
        public EstadoCivilController(EstadoCivilService estadocivilService, IMapper mapper)
        {
            _estadocivilService = estadocivilService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult ListarEstadosCiviles()
        {
            var response = _estadocivilService.ListarEstadosCiviles();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarEstadoCivil(int id)
        {
            var response = _estadocivilService.BuscarEstadoCivil(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(EstadosCivilesViewModel estadoscivilesViewModel)
        {
            var modelo = _mapper.Map<EstadosCivilesViewModel, tbEstadosCiviles>(estadoscivilesViewModel); 
            var response = _estadocivilService.InsertarEstadoCivil(modelo); 
            return Ok(response); 
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(EstadosCivilesViewModel estadoscivilesViewModel)
        {
            var modelo = _mapper.Map<EstadosCivilesViewModel, tbEstadosCiviles>(estadoscivilesViewModel); 
            var response = _estadocivilService.ActualizarEstadoCivil(modelo); 
            return Ok(response); 
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _estadocivilService.EliminarEstadoCivil(id);
            return Ok(response);
        }
    }
}

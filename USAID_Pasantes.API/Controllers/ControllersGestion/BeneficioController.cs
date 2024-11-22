using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USAID_Pasantes.BusinessLogic.Services.ServicesGestion;
using USAID_Pasantes.Common.Models.ModelsGestion;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API.Controllers.ControllersGestion
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficioController : Controller
    {
        private readonly BeneficioService _beneficioService;
        private readonly IMapper _mapper;
        public BeneficioController(BeneficioService beneficioService, IMapper mapper)
        {
            _beneficioService = beneficioService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult ListarBeneficios()
        {
            var response = _beneficioService.ListarBeneficios();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarBeneficio(int id)
        {
            var response = _beneficioService.BuscarBeneficio(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(BeneficioViewModel beneficioViewModel)
        {
            var modelo = _mapper.Map<BeneficioViewModel, tbBeneficios>(beneficioViewModel);
            var response = _beneficioService.InsertarBeneficio(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(BeneficioViewModel beneficioViewModel)
        {
            var modelo = _mapper.Map<BeneficioViewModel, tbBeneficios>(beneficioViewModel);
            var response = _beneficioService.ActualizarBeneficio(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _beneficioService.EliminarBeneficio(id);
            return Ok(response);
        }
    }
}

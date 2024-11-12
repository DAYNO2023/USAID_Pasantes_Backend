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
    public class BancoController : Controller
    {
        private readonly BancoService _bancoService;
        private readonly IMapper _mapper;
        public BancoController(BancoService bancoService, IMapper mapper)
        {
            _bancoService = bancoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarBancos()
        {
            var response = _bancoService.ListarBancos();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarBanco(int id)
        {
            var response = _bancoService.BuscarBanco(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(BancoViewModel bancoViewModel)
        {
            var modelo = _mapper.Map<BancoViewModel, tbBancos>(bancoViewModel);
            var response = _bancoService.InsertarBanco(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(BancoViewModel bancoViewModel)
        {
            var modelo = _mapper.Map<BancoViewModel, tbBancos>(bancoViewModel);
            var response = _bancoService.ActualizarBanco(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _bancoService.EliminarBanco(id);
            return Ok(response);
        }

    }
}

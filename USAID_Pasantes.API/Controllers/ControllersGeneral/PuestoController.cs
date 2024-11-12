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
    public class PuestoController : Controller
    {
        private readonly PuestoService _puestoService;
        private readonly IMapper _mapper;
        public PuestoController(PuestoService puestoService, IMapper mapper)
        {
            _puestoService = puestoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarPuestos()
        {
            var response = _puestoService.ListarPuestos();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarPuesto(int id)
        {
            var response = _puestoService.BuscarPuesto(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(PuestoViewModel puestoViewModel)
        {
            var modelo = _mapper.Map<PuestoViewModel, tbPuestos>(puestoViewModel);
            var response = _puestoService.InsertarPuesto(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(PuestoViewModel puestoViewModel)
        {
            var modelo = _mapper.Map<PuestoViewModel, tbPuestos>(puestoViewModel);
            var response = _puestoService.ActualizarPuesto(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _puestoService.EliminarPuesto(id);
            return Ok(response);
        }
    }
}

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
    public class DepartamentoController : Controller
    {
        private readonly DepartamentoService _departamentoService;
        private readonly IMapper _mapper;
        public DepartamentoController(DepartamentoService departamentoService, IMapper mapper)
        {
            _departamentoService = departamentoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarDepartamento()
        {
            var response = _departamentoService.ListarDepartamentos();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarDepartamento(int id)
        {
            var response = _departamentoService.BuscarDepartamento(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(DepartamentoViewModel departamentoViewModel)
        {
            var modelo = _mapper.Map<DepartamentoViewModel, tbDepartamentos>(departamentoViewModel);
            var response = _departamentoService.InsertarDepartamento(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(DepartamentoViewModel departamentoViewModel)
        {
            var modelo = _mapper.Map<DepartamentoViewModel, tbDepartamentos>(departamentoViewModel);
            var response = _departamentoService.ActualizarDepartamento(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _departamentoService.EliminarDepartamento(id);
            return Ok(response);
        }
    }
}

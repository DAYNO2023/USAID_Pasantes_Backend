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
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoService _empleadoService;
        private readonly IMapper _mapper;
        public EmpleadoController(EmpleadoService empleadoService, IMapper mapper)
        {
            _empleadoService = empleadoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarEmpleados()
        {
            var response = _empleadoService.ListarEmpleados();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarEmpleado(int id)
        {
            var response = _empleadoService.BuscarEmpleado(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(EmpleadoViewModel empleadoViewModel)
        {
            var modelo = _mapper.Map<EmpleadoViewModel, tbEmpleados>(empleadoViewModel);
            var response = _empleadoService.InsertarEmpleado(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(EmpleadoViewModel empleadoViewModel)
        {
            var modelo = _mapper.Map<EmpleadoViewModel, tbEmpleados>(empleadoViewModel);
            var response = _empleadoService.ActualizarEmpleado(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _empleadoService.EliminarEmpleado(id);
            return Ok(response);
        }

    }
}

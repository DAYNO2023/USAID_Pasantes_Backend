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
    public class FacultadController : Controller
    {
        private readonly FacultadService _FacultadService;
        private readonly IMapper _mapper;
        public FacultadController(FacultadService facultadService, IMapper mapper)
        {
            _FacultadService = facultadService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarFacultades()
        {
            var response = _FacultadService.ListarFacultades();
            return Ok(response.Data);
        }

        /// <summary>
        /// Obtiene una lista de todas las facultades por la regional seleccionada.
        /// </summary>
        /// <returns>Lista de facultades disponibles.</returns>
        [HttpGet("ListarPorRegional/{id}")]
        public IActionResult ListarFacultadesPorRegional(int id)
        {
            var response = _FacultadService.ListarFacultadesPorRegional(id);
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarFacultad(int id)
        {
            var response = _FacultadService.BuscarFacultad(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(FacultadViewModel facultadViewModel)
        {
            var modelo = _mapper.Map<FacultadViewModel, tbFacultades>(facultadViewModel);
            var response = _FacultadService.InsertarFacultad(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(FacultadViewModel facultadViewModel)
        {
            var modelo = _mapper.Map<FacultadViewModel, tbFacultades>(facultadViewModel);
            var response = _FacultadService.ActualizarFacultad(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _FacultadService.EliminarFacultad(id);
            return Ok(response);
        }
    }
}

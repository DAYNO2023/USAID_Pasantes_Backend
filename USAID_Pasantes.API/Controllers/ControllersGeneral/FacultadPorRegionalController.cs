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
    public class FacultadPorRegionalController : Controller
    {
        private readonly FacultadPorRegionalService _facultadPorRegionalService;
        private readonly IMapper _mapper;
        public FacultadPorRegionalController(FacultadPorRegionalService facultadPorRegionalService, IMapper mapper)
        {
            _facultadPorRegionalService = facultadPorRegionalService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarFacultadPorRegional()
        {
            var response = _facultadPorRegionalService.ListarFacultadPorRegional();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarFacultadPorRegional(int id)
        {
            var response = _facultadPorRegionalService.BuscarFacultadPorRegional(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(FacultadPorRegionalViewModel facultadPorRegionalViewModel)
        {
            var modelo = _mapper.Map<FacultadPorRegionalViewModel, tbFacultadPorRegional>(facultadPorRegionalViewModel);
            var response = _facultadPorRegionalService.InsertarFacultadPorRegional(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(FacultadPorRegionalViewModel facultadPorRegionalViewModel)
        {
            var modelo = _mapper.Map<FacultadPorRegionalViewModel, tbFacultadPorRegional>(facultadPorRegionalViewModel);
            var response = _facultadPorRegionalService.ActualizarFacultadPorRegional(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _facultadPorRegionalService.EliminarFacultadPorRegional(id);
            return Ok(response);
        }
    }
}

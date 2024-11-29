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
    public class MunicipioController : Controller
    {
        private readonly MunicipioService _municipioService;
        private readonly IMapper _mapper;
        public MunicipioController(MunicipioService municipioService, IMapper mapper)
        {
            _municipioService = municipioService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult ListarMunicipios()
        {
            var response = _municipioService.ListarMunicipios();
            return Ok(response.Data);
        }

        [HttpGet("ListarPorDepartamento/{id}")]
        public IActionResult ListarMunicipiosPorDepartamento(string id)
        {
            var response = _municipioService.ListarMunicipiosPorDepartamento(id);
            return Ok(response.Data);
        }
        
        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarMunicipio(int id)
        {
            var response = _municipioService.BuscarMunicipio(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(MunicipioViewModel municipioViewModel)
        {
            var modelo = _mapper.Map<MunicipioViewModel, tbMunicipios>(municipioViewModel);
            var response = _municipioService.InsertarMunicipio(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(MunicipioViewModel municipioViewModel)
        {
            var modelo = _mapper.Map<MunicipioViewModel, tbMunicipios>(municipioViewModel);
            var response = _municipioService.ActualizarMunicipio(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _municipioService.EliminarMunicipio(id);
            return Ok(response);
        }
    }
}

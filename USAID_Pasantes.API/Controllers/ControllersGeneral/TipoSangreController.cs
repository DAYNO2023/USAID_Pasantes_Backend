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
    public class TipoSangreController : Controller
    {
        private readonly TipoSangreService _tipoSangreService;
        private readonly IMapper _mapper;
        public TipoSangreController(TipoSangreService tipoSangreService, IMapper mapper)
        {
            _tipoSangreService = tipoSangreService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarTipoSangres()
        {
            var response = _tipoSangreService.ListarTipoSangres();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarTipoSangre(int id)
        {
            var response = _tipoSangreService.BuscarTipoSangre(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(TipoSangreViewModel tipoSangreViewModel)
        {
            var modelo = _mapper.Map<TipoSangreViewModel, tbTipoSangre>(tipoSangreViewModel);
            var response = _tipoSangreService.InsertarTipoSangre(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(TipoSangreViewModel tipoSangreViewModel)
        {
            var modelo = _mapper.Map<TipoSangreViewModel, tbTipoSangre>(tipoSangreViewModel);
            var response = _tipoSangreService.ActualizarTipoSangre(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _tipoSangreService.EliminarTipoSangre(id);
            return Ok(response);
        }
    }
}

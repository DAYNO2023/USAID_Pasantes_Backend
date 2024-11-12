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
    public class TipoDocumentoController : Controller
    {
        private readonly TipoDocumentoService _tipoDocumentoService;
        private readonly IMapper _mapper;
        public TipoDocumentoController(TipoDocumentoService tipoDocumentoService, IMapper mapper)
        {
            _tipoDocumentoService = tipoDocumentoService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult ListarTipoDocumentos()
        {
            var response = _tipoDocumentoService.ListarTipoDocumentos();
            return Ok(response.Data);
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarTipoDocumento(int id)
        {
            var response = _tipoDocumentoService.BuscarTipoDocumento(id);
            return Ok(response.Data);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            var modelo = _mapper.Map<TipoDocumentoViewModel, tbTipoDocumento>(tipoDocumentoViewModel);
            var response = _tipoDocumentoService.InsertarTipoDocumento(modelo);
            return Ok(response);
        }

        [HttpPut("Actualizar")]
        public IActionResult Update(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            var modelo = _mapper.Map<TipoDocumentoViewModel, tbTipoDocumento>(tipoDocumentoViewModel);
            var response = _tipoDocumentoService.ActualizarTipoDocumento(modelo);
            return Ok(response);
        }

        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _tipoDocumentoService.EliminarTipoDocumento(id);
            return Ok(response);
        }
    }
}

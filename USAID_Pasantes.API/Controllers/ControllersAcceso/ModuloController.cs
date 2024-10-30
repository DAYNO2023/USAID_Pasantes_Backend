using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesAcceso;

namespace USAID_Pasantes.API.Controllers.ControllersAcceso
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuloController : Controller
    {
        private readonly ModuloService _moduloService;
        private readonly IMapper _mapper;

        public ModuloController(ModuloService moduloService, IMapper mapper)
        {
            _mapper = mapper;
            _moduloService = moduloService;
        }


        [HttpGet("Listar")]
        public IActionResult ListarEstadoCivil()
        {
            var response = _moduloService.ListarModulos();
            return Ok(response.Data);
        }

    }
}

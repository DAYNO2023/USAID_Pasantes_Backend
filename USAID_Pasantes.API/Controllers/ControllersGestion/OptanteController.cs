using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USAID_Pasantes.BusinessLogic.Services.ServicesGestion;
using USAID_Pasantes.Common.Models.ModelsGestion;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API.Controllers.ControllersGestion
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptanteController : Controller
    {
        private readonly OptanteService _optanteService;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor del controlador de Optante que inicializa el servicio y el mapeador.
        /// </summary>
        /// <param name="optanteService">Instancia del servicio de optantes.</param>
        /// <param name="mapper">Instancia del mapeador para conversiones de modelos.</param>
        public OptanteController(OptanteService optanteService, IMapper mapper)
        {
            _optanteService = optanteService;
            _mapper = mapper;
        }


        /// <summary>
        /// Obtiene una lista de todos los optantes.
        /// </summary>
        /// <returns>Lista de optantes disponibles.</returns>
        [HttpGet("Listar")]
        public IActionResult ListarOptantes()
        {
            var response = _optanteService.ListarOptantes();
            return Ok(response.Data);
        }

        /// <summary>
        /// Registra un nuevo optante.
        /// </summary>
        /// <param name="optanteViewModel">Modelo de vista con los detalles del optante a registrar.</param>
        /// <returns>Resultado de la operación de registro.</returns>
        [HttpPost("Registrar")]
        public IActionResult Register(OptanteViewModel optanteViewModel)
        {
            var modelo = _mapper.Map<OptanteViewModel, tbOptantes>(optanteViewModel);
            var response = _optanteService.RegistrarOptante(modelo);
            return Ok(response);
        }

        /// <summary>
        /// Busca un optante por su ID.
        /// </summary>
        /// <param name="id">ID del optante a buscar.</param>
        /// <returns>El optante encontrado.</returns>
        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarOptante(int id)
        {
            var response = _optanteService.BuscarOptante(id);
            return Ok(response.Data);
        }

        /// <summary>
        /// Inserta un nuevo optante.
        /// </summary>
        /// <param name="optanteViewModel">Modelo de vista con los detalles del optante a insertar.</param>
        /// <returns>Resultado de la operación de inserción.</returns>
        [HttpPost("Insertar")]
        public IActionResult Create(OptanteViewModel optanteViewModel)
        {
            var modelo = _mapper.Map<OptanteViewModel, tbOptantes>(optanteViewModel);
            var response = _optanteService.InsertarOptante(modelo);
            return Ok(response);
        }

        /// <summary>
        /// Actualiza un optante existente.
        /// </summary>
        /// <param name="optanteViewModel">Modelo de vista con los datos actualizados del optante.</param>
        /// <returns>Resultado de la operación de actualización.</returns>
        [HttpPut("Actualizar")]

        public IActionResult Update(OptanteViewModel optanteViewModel)
        {
            var modelo = _mapper.Map<OptanteViewModel, tbOptantes>(optanteViewModel);
            var response = _optanteService.ActualizarOptante(modelo);
            return Ok(response);
        }

        /// <summary>
        /// Elimina un optante por su ID.
        /// </summary>
        /// <param name="id">ID del optante a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación.</returns>
        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _optanteService.EliminarOptante(id);
            return Ok(response);
        }
    }
}

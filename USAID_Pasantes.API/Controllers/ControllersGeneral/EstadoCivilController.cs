using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USAID_Pasantes.BusinessLogic.Services.ServicesGeneral;
using USAID_Pasantes.Common.Models.ModelsGeneral;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API.Controllers.ControllersGeneral
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCivilController : Controller
    {
        private readonly EstadoCivilService _estadocivilService;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor del controlador de Estado Civil que inicializa el servicio y el mapeador.
        /// </summary>
        /// <param name="estadocivilService">Instancia del servicio de estados civiles.</param>
        /// <param name="mapper">Instancia del mapeador para conversiones de modelos.</param>
        public EstadoCivilController(EstadoCivilService estadocivilService, IMapper mapper)
        {
            _estadocivilService = estadocivilService;
            _mapper = mapper;
        }


        /// <summary>
        /// Obtiene una lista de todos los estados civiles.
        /// </summary>
        /// <returns>Lista de estados civiles disponibles.</returns>
        [HttpGet("Listar")]
        public IActionResult ListarEstadosCiviles()
        {
            var response = _estadocivilService.ListarEstadosCiviles();
            return Ok(response.Data);
        }

        /// <summary>
        /// Busca un estado civil por su ID.
        /// </summary>
        /// <param name="id">ID del estado civil a buscar.</param>
        /// <returns>El estado civil encontrado.</returns>
        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarEstadoCivil(int id)
        {
            var response = _estadocivilService.BuscarEstadoCivil(id);
            return Ok(response.Data);
        }

        /// <summary>
        /// Inserta un nuevo estado civil.
        /// </summary>
        /// <param name="estadoscivilesViewModel">Modelo de vista con los detalles del estado civil a insertar.</param>
        /// <returns>Resultado de la operación de inserción.</returns>
        [HttpPost("Insertar")]
        public IActionResult Create(EstadosCivilesViewModel estadoscivilesViewModel)
        {
            var modelo = _mapper.Map<EstadosCivilesViewModel, tbEstadosCiviles>(estadoscivilesViewModel); 
            var response = _estadocivilService.InsertarEstadoCivil(modelo); 
            return Ok(response); 
        }

        /// <summary>
        /// Actualiza un estado civil existente.
        /// </summary>
        /// <param name="estadoscivilesViewModel">Modelo de vista con los datos actualizados del estado civil.</param>
        /// <returns>Resultado de la operación de actualización.</returns>
        [HttpPut("Actualizar")]

        public IActionResult Update(EstadosCivilesViewModel estadoscivilesViewModel)
        {
            var modelo = _mapper.Map<EstadosCivilesViewModel, tbEstadosCiviles>(estadoscivilesViewModel); 
            var response = _estadocivilService.ActualizarEstadoCivil(modelo); 
            return Ok(response); 
        }

        /// <summary>
        /// Elimina un estado civil por su ID.
        /// </summary>
        /// <param name="id">ID del estado civil a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación.</returns>
        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _estadocivilService.EliminarEstadoCivil(id);
            return Ok(response);
        }
    }
}

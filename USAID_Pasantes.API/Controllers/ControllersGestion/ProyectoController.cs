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
    public class ProyectoController : Controller
    {
        private readonly ProyectoService _proyectoService;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor del controlador de Proyecto que inicializa el servicio y el mapeador.
        /// </summary>
        /// <param name="proyectoService">Instancia del servicio de proyectos.</param>
        /// <param name="mapper">Instancia del mapeador para conversiones de modelos.</param>
        public ProyectoController(ProyectoService proyectoService, IMapper mapper)
        {
            _proyectoService = proyectoService;
            _mapper = mapper;
        }


        /// <summary>
        /// Obtiene una lista de todos los proyectos.
        /// </summary>
        /// <returns>Lista de proyectos disponibles.</returns>
        [HttpGet("Listar")]
        public IActionResult ListarProyectos()
        {
            var response = _proyectoService.ListarProyectos();
            return Ok(response.Data);
        }

        /// <summary>
        /// Busca un proyecto por su ID.
        /// </summary>
        /// <param name="id">ID del proyecto a buscar.</param>
        /// <returns>El proyecto encontrado.</returns>
        [HttpGet("Buscar/{id}")]
        public IActionResult BuscarProyecto(int id)
        {
            var response = _proyectoService.BuscarProyecto(id);
            return Ok(response.Data);
        }

        /// <summary>
        /// Inserta un nuevo proyecto.
        /// </summary>
        /// <param name="proyectosViewModel">Modelo de vista con los detalles del proyecto a insertar.</param>
        /// <returns>Resultado de la operación de inserción.</returns>
        [HttpPost("Insertar")]
        public IActionResult Create(ProyectoViewModel proyectosViewModel)
        {
            var modelo = _mapper.Map<ProyectoViewModel, tbProyectos>(proyectosViewModel);
            var response = _proyectoService.InsertarProyecto(modelo);
            return Ok(response);
        }

        /// <summary>
        /// Actualiza un proyecto existente.
        /// </summary>
        /// <param name="proyectosViewModel">Modelo de vista con los datos actualizados del proyecto.</param>
        /// <returns>Resultado de la operación de actualización.</returns>
        [HttpPut("Actualizar")]

        public IActionResult Update(ProyectoViewModel proyectosViewModel)
        {
            var modelo = _mapper.Map<ProyectoViewModel, tbProyectos>(proyectosViewModel);
            var response = _proyectoService.ActualizarProyecto(modelo);
            return Ok(response);
        }

        /// <summary>
        /// Elimina un proyecto por su ID.
        /// </summary>
        /// <param name="id">ID del proyecto a eliminar.</param>
        /// <returns>Resultado de la operación de eliminación.</returns>
        [HttpDelete("Eliminar")]
        public IActionResult Delete(int id)
        {
            var response = _proyectoService.EliminarProyecto(id);
            return Ok(response);
        }
    }
}

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
        private readonly IMailService _mailService;
        /// <summary>
        /// Constructor del controlador de Optante que inicializa el servicio y el mapeador.
        /// </summary>
        /// <param name="optanteService">Instancia del servicio de optantes.</param>
        /// <param name="mapper">Instancia del mapeador para conversiones de modelos.</param>
        public OptanteController(OptanteService optanteService, IMapper mapper, IMailService mailService)
        {
            _optanteService = optanteService;
            _mapper = mapper;
            _mailService = mailService;
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

        [HttpGet("EnviarCorreoConCredenciales/{opta_Id}/{opta_Nombres}/{opta_Apellidos}/{opta_CorreoElectronico}/{usuario}/{contraseña}")]
        public IActionResult EnviarCorreoConCredenciales(
            int opta_Id,
            string opta_Nombres,
            string opta_Apellidos,
            string opta_CorreoElectronico,
            string usuario,
            string contraseña)
        {
            // Crear el cuerpo del correo
            var mailData = new MailData
            {
                EmailToId = opta_CorreoElectronico,
                EmailToName = $"{opta_Nombres} {opta_Apellidos}",
                EmailSubject = "Credenciales de Acceso al Sistema USAID",
                EmailBody = $@"
                    Estimado/a {opta_Nombres} {opta_Apellidos},

                    Se ha registrado exitosamente en nuestro sistema. A continuación, 
                    le proporcionamos sus credenciales de acceso:

                    Usuario: {usuario}
                    Contraseña: {contraseña}

                    Por favor, cambie su contraseña al iniciar sesión por primera vez.

                    Atentamente,
                    El equipo de soporte de USAID"
            };

            // Enviar el correo utilizando _mailService
            var result = _mailService.SendMail(mailData);

            // Verificar si el correo fue enviado exitosamente
            if (result)
            {
                return Ok(new { Message = "Correo enviado exitosamente con las credenciales.", OptanteId = opta_Id });
            }
            else
            {
                return BadRequest(new { Message = "El correo no pudo ser enviado.", OptanteId = opta_Id });
            }
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

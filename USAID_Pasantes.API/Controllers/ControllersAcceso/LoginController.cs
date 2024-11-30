using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using USAID_Pasantes.Common.Models.ModelsAcceso;
using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USAID_Pasantes.BusinessLogic.Services.ServicesAcceso;

namespace USAID_Pasantes.API.Controllers.ControllersAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;
        public LoginController(LoginService loginService, IMapper mapper, IMailService mailService)
        {
            _loginService = loginService;
            _mapper = mapper;
            _mailService = mailService;
        }

        [HttpGet("InicioSesion/{usuario}/{clave}")]
        public IActionResult IniciiarSesion(string usuario, string clave)
        {
            var response = _loginService.IniciarSesion(usuario, clave);

            if (response.Success)
                return Ok(response.Data);
            else
                return BadRequest(response.Message);
        }


        [HttpGet("ControlCorreo/{correo_usuario}/{codigo}")]
        public Boolean EnviarCorreo(string correo_usuario, int codigo, string usuario)
        {
            MailData mailData = new MailData();
            mailData.EmailToId = correo_usuario;
            mailData.EmailToName = "Usuario";
            mailData.EmailSubject = "Código de Verificación para Restablecimiento de Contraseña";

            // Mejor formato para el cuerpo del correo
            mailData.EmailBody = $@"
            Estimado/a {usuario},

            Hemos recibido una solicitud para restablecer la contraseña de su cuenta en USAID.

            Su código de verificación es: {codigo}

            Por favor, ingrese este código en la página de restablecimiento de contraseña para completar el proceso.

            Si usted no solicitó este restablecimiento, ignore este correo o contacte a nuestro equipo de soporte.

            Atentamente,
            El equipo de soporte de USAID
            ";

            var result = _mailService.SendMail(mailData);
            return result;
        }

        [HttpGet("EnviarCorreo/{usua_Id}/{empl_Correo}/{usuario}")]
        public IActionResult RestablecerContra(int usua_Id, string empl_Correo, string usuario)
        {
            var result = _loginService.InsertarCodigoRestablecer(usua_Id);
            var resu = result.Data.Message;

            var reultNuevo = EnviarCorreo(empl_Correo, int.Parse(resu), usuario);

            result.Success = reultNuevo;

            return Ok(result);
        }

        [HttpGet("VerificarCodigoReestablecer/{usua_Id}/{codigo}")]
        public IActionResult VerificarCodigoReestablecerWeb(int usua_Id, int codigo)
        {
            var result = _loginService.VerificarCodigoReestablecer(usua_Id, codigo);

            return Ok(result);
        }

        [HttpGet("BuscarUsuario/{id}")]
        public IActionResult Buscar(int id)
        {
            var usuario = _loginService.BuscarUsuario(id);

            return Ok(usuario);
        }

        [HttpPut("ReestablecerClave")]
        public IActionResult Reestablecer(UsuarioViewModel UsuarioViewModel)
        {
            var modelo = new tbUsuarios()
            {
                usua_Id = UsuarioViewModel.usua_Id,
                usua_Clave = UsuarioViewModel.usua_Clave,
            };

            var result = _loginService.ReestablecerUsuario(modelo);

            return Ok(result);
        }


    }
}

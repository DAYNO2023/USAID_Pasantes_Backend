using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USAID_Pasantes.API.Controllers.ControllersComunicacion
{
    public class ForoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal2020v2.Interface;
using Microsoft.AspNetCore.Http;
//using ProyectoFinal2020v2.Filters;

namespace ProyectoFinal2020v2.Controllers
{
   // [ValidateUserSession]
    public class UsuarioPerfilController : Controller
    {
        IUsuarios _IRepository;
        public UsuarioPerfilController(IUsuarios IRepository)
        {
            _IRepository = IRepository;
        }

        [HttpGet]
        public IActionResult Profile()
        {
            try
            {
                var profile = _IRepository.Userinformation(Convert.ToInt32(HttpContext.Session.GetString("IdUsuario")));
                return View(profile);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
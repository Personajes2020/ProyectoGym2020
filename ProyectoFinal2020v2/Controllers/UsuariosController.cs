using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal2020v2.Interface;


namespace ProyectoFinal2020v2.Controllers
{
    public class UsuariosController : Controller
    {
        IUsuarios _IRepository;
        IRoles _IRoles;
        public UsuariosController(IUsuarios IRepository, IRoles IRoles)
        {
            _IRepository = IRepository;
            _IRoles = IRoles;
        }
        [HttpGet]
        public IActionResult Usuarios()
        {
            try
            {
                Usuarios Usuarios = new Usuarios();
                //Registration.Country = null;
                //Registration.City = null;
                //Registration.State = null;
                return View(Usuarios);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Usuarios(Usuarios Usuarios)
        {
            try
            {
                var isUsernameExists = _IRepository.CheckUserNameExists(Usuarios.NombreUsuario);

                if (isUsernameExists)
                {
                    ModelState.AddModelError("", errorMessage: "Nombre de usuario en uso, porfavor elija otro!");
                }
                else
                {
                    Usuarios.FechaCreacion = DateTime.Now;
                    Usuarios.IdRole = Usuarios.IdRole;
                    Usuarios.Contraseña = (Usuarios.Contraseña);
                    Usuarios.ConfirmarContraseña = (Usuarios.ConfirmarContraseña);
                    if (_IRepository.AddUser(Usuarios) > 0)
                    {
                        TempData["MessageRegistration"] = "Usuario creado correctamente!";

                        return View(Usuarios);
                    }
                    else
                    {
                        return View(Usuarios);
                    }
                }

                return View(Usuarios);
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        public JsonResult CheckUserNameExists(string NombreUsuario)
        {
            try
            {
                var isUsernameExists = _IRepository.CheckUserNameExists(NombreUsuario);
                if (isUsernameExists)
                {
                    return Json(data: true);
                }
                else
                {
                    return Json(data: false);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

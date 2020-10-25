using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProyectoFinal2020v2.Interface;
using ProyectoFinal2020v2.Models;


namespace ProyectoFinal2020v2.Controllers
{
    public class LoginController : Controller
    {
        ILogin _ILogin;

        public LoginController(ILogin ILogin)
        {
            _ILogin = ILogin;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(loginViewModel.NombreUsuario) && !string.IsNullOrEmpty(loginViewModel.Contraseña))
                {
                    var NombreUsuario = loginViewModel.NombreUsuario;
                    var Contraseña = loginViewModel.Contraseña;

                    var result = _ILogin.ValidateUser(NombreUsuario, Contraseña);

                    if (result != null)
                    {
                        if (result.IdUsuario == 0 || result.IdUsuario < 0)
                        {
                            ViewBag.errormessage = "Usuario y contraseña invalido";
                        }
                        else
                        {
                            var IdRole = result.IdRole;
                            //remove_Anonymous_Cookies(); //Remove Anonymous_Cookies

                            HttpContext.Session.SetString("IdUsuario", Convert.ToString(result.IdUsuario));
                            HttpContext.Session.SetString("IdRole", Convert.ToString(result.IdRole));
                            HttpContext.Session.SetString("NombreUsuario", Convert.ToString(result.NombreUsuario));
                            if (IdRole == 1)
                            {
                                return RedirectToAction("Index", "Admin");
                            }
                            else if (IdRole == 2)
                            {
                                return RedirectToAction("IndexU", "Usuarios");
                            }
                            else if (IdRole == 3)
                            {
                                return RedirectToAction("Index", "Empleado");
                            }
                        }
                    }
                    else
                    {
                        ViewBag.errormessage = "Nombre y contraseña invalido";
                        return View();
                    }
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            try
            {
                CookieOptions option = new CookieOptions();

                if (Request.Cookies["EventChannel"] != null)
                {
                    option.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Append("EventChannel", "", option);
                }

                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Login");
            }
            catch (Exception)
            {
                throw;
            }

        }

        [NonAction]
        public void remove_Anonymous_Cookies()
        {
            if (Request.Cookies["EventChannel"] != null)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Append("EventChannel", "", option);
            }
        }

    }
}


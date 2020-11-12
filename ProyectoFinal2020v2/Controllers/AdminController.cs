using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinal2020v2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gym()
        {
            return View();
        }
        public IActionResult Guarderia()
        {
            return View();
        }
        public IActionResult Tienda()
        {
            return View();
        }
    }
}

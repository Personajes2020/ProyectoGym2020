using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal2020v2.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2;
using ProyectoFinal2020v2.Models;
using Microsoft.AspNetCore.Http;
//using ProyectoFinal2020v2.Filters;

namespace ProyectoFinal2020v2.Controllers
{
    public class UsuariosController : Controller
    {
        IUsuarios _IRepository;
        IRoles _IRoles;
        private readonly GymContext _context;
        public UsuariosController(IUsuarios IRepository, IRoles IRoles, GymContext context)
        {
            _IRepository = IRepository;
            _IRoles = IRoles;
            _context = context;
        }
        [HttpGet]
        public IActionResult Usuarios()
        {
            try
            {
                Usuarios Usuarios = new Usuarios();
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
                        //Thread.Sleep(1000);

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
        public IActionResult IndexU()
        {
            return View();
        }


        // GET: UsuariosG
        public async Task<IActionResult> Index()
        {
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");
            var gymContext = _context.Usuarios.Include(c => c.IdRoleNavigation);
            return View(await gymContext.ToListAsync());
        }

        // GET: UsuariosG/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .Include(c => c.IdRoleNavigation)
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuarios == null)
            {
                return NotFound();
            }
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");
            return View(usuarios);

        }

        // GET: UsuariosG/Create
        public IActionResult Create()
        {
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");

            return View();
        }

        // POST: UsuariosG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,NombreUsuario,Contraseña,FechaCreacion,Activo,ConfirmarContraseña,IdRole")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarios);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole", usuarios.IdRole);
            return View(usuarios);
        }

        // GET: UsuariosG/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios.FindAsync(id);
            if (usuarios == null)
            {
                return NotFound();
            }
            return View(usuarios);
        }

        // POST: UsuariosG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,NombreUsuario,Contraseña,FechaCreacion,Activo,ConfirmarContraseña,IdRole")] Usuarios usuarios)
        {
            if (id != usuarios.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuariosExists(usuarios.IdUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole", usuarios.IdRole);
            return View(usuarios);
        }

        // GET: UsuariosG/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (usuarios == null)
            {
                return NotFound();
            }
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");
            return View(usuarios);
        }

        // POST: UsuariosG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Usuarios usuarios)
        {
            //string mensaje = "Error al eliminar actividad";
            Usuarios usuariosFind = _context.Usuarios.Find(usuarios.IdUsuario);
            _context.Usuarios.Remove(usuariosFind);
            _context.SaveChanges();
            //mensaje = "Actividad elminada!";
            return Json(new { result = true, });
        }



        // POST: Actividads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult CreateConAjax([Bind("IdUsuario,NombreUsuario,Contraseña,FechaCreacion,Activo,ConfirmarContraseña,IdRole")] Usuarios usuarios)
        //{//ESTE METODO LO QUE HACE ES RETORNAR UN RESULT PARA UTILIZARLO EN LA VISTA CREATE JUNTO LA SWEET ALERT

        //    if (ModelState.IsValid)
        //    {
        //        //_context.Add(actividad);
        //        //await _context.SaveChangesAsync();
        //        return Json(new { result = true }); //Si guarda result true
        //    }
        //    return Json(new { result = false }); //Si no guarda result = false
        //}
        public ActionResult EditConAjax(Usuarios usuarios)
        {
            //string mensaje = "Error al editar el registro";
            if (ModelState.IsValid)
            {
                // _context.Entry(actividad).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { result = true });
                //mensaje = "Registro editado";
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UsuariosCrear(Usuarios Usuarios)
        {
            ViewData["IdRole"] = new SelectList(_context.Roles, "IdRole", "NombreRole");
            try
            {
                var isUsernameExists = _IRepository.CheckUserNameExists(Usuarios.NombreUsuario);

                if (isUsernameExists)
                {

                    ModelState.AddModelError("  ",errorMessage: "Nombre de usuario en uso, porfavor elija otro!");
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
            //if (ModelState.IsValid)
            //{
            //    //_context.Add(actividad);
            //    //await _context.SaveChangesAsync();
            //    return Json(new { result = true }); //Si guarda result true
            //}
            //return Json(new { result = false }); //Si no guarda result = false


        }
        //[ValidateUserSession]
        //[HttpGet]
        //public IActionResult Profile()
        //{
        //    try
        //    {
        //        var profile = _IRepository.Userinformation(Convert.ToInt32(HttpContext.Session.GetString("IdUsuario")));
        //        return View(profile);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //[HttpGet]
        //public ActionResult Profile()
        //{
        //    try
        //    {
        //        var profile = _IRepository.Userinformation(Convert.ToInt32(HttpContext.Session.GetString("IdUsuario")));
        //        return View(profile);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

    }
}


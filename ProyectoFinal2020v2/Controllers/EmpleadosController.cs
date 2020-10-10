using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2.Models;

namespace ProyectoFinal2020v2.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly GymContext _context;

        public EmpleadosController(GymContext context)
        {
            _context = context;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleado.ToListAsync());
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .FirstOrDefaultAsync(m => m.IdEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmpleado,Identificacion,Nombre,Apellido1,Apellido2,FechaNac,Telefono,Direccion,Email,Sexo,Area,TipoDeEmp,NumeroSocial,NumeroBancario,Ccss,Profesion,FechaContrato,Estado")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                var validacionDNI = _context.Empleado.Any(e => e.Identificacion.Equals(empleado.Identificacion));
                var validacionGmail = _context.Empleado.Any(e => e.Email.Equals(empleado.Email));

                if (validacionDNI || validacionGmail)
                {
                    if (validacionGmail)
                    {
                        ModelState.AddModelError("Email", "Este correo ya esta registrado, intente con otro.");
                    }
                    if (validacionDNI)
                    {
                        ModelState.AddModelError("Identificacion", "Este empleado ya esta registrado");
                    }
                    return View("Create");

                }
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmpleado,Identificacion,Nombre,Apellido1,Apellido2,FechaNac,Telefono,Direccion,Email,Sexo,Area,TipoDeEmp,NumeroSocial,NumeroBancario,Ccss,Profesion,FechaContrato,Estado")] Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpleadoExists(empleado.IdEmpleado))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado
                .FirstOrDefaultAsync(m => m.IdEmpleado == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleado.FindAsync(id);
            _context.Empleado.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleado.Any(e => e.IdEmpleado == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                //_context.Empleado.Add(empleado);
                //_context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        public ActionResult EditConAjax(Empleado empleado)
        {
            if (ModelState.IsValid)
            { 
                _context.SaveChanges();
                return Json(new { result = true });
                
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Empleado empleado)
        {
            Empleado empleadoFind = _context.Empleado.Find(empleado.IdEmpleado);
            _context.Empleado.Remove(empleadoFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }

    }
}


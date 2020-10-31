using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2.Models;

namespace ProyectoFinal2020v2.Controllers
{
    public class ClaseGuarderiaEmpleadosController : Controller
    {
        private readonly GymContext _context;

        public ClaseGuarderiaEmpleadosController(GymContext context)
        {
            _context = context;
        }

        // GET: ClaseGuarderiaEmpleados
        //public async Task<IActionResult> Index()
        //{
        //    var gymContext = _context.ClaseGuarderiaEmpleado.Include(c => c.IdClaseGuarderiaNavigation).Include(c => c.IdEmpleadoNavigation);
        //    return View(await gymContext.ToListAsync());
        //}

        // GET: ClaseGuarderiaEmpleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGuarderiaEmpleado = await _context.ClaseGuarderiaEmpleado
                .Include(c => c.IdClaseGuarderiaNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdClaseGuarderiaEmpleado == id);
            if (claseGuarderiaEmpleado == null)
            {
                return NotFound();
            }

            return RedirectToAction("Detalis", "clasesguarderia", claseGuarderiaEmpleado);
        }
        //public async Task<IActionResult> DetailsEmpleado(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var empleado = await _context.Empleado
        //        .FirstOrDefaultAsync(m => m.IdEmpleado == id);
        //    if (empleado == null)
        //    {
        //        return NotFound();
        //    }

        //    return View("DetailsEmpleado", empleado);
        //}
        // GET: ClaseGuarderiaEmpleados/Create
        public IActionResult Create()
        {

            ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "IdClaseGuarderia");
            ViewData["IdEmpleado"] = _context.Empleado
               .Select(e => new SelectListItem
               {
                   Text = e.Nombre + " " + e.Apellido1,
                   Value = e.IdEmpleado.ToString()
               });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Nombre");
            return View();
        }

        // POST: ClaseGuarderiaEmpleados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdClaseGuarderiaEmpleado,IdClaseGuarderia,IdEmpleado")] ClaseGuarderiaEmpleado claseGuarderiaEmpleado)
        {
            if (ModelState.IsValid)
            {
                
               
                _context.Add(claseGuarderiaEmpleado);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction("Index", "ClasesGuarderia");
            }
            ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "IdClaseGuarderia", claseGuarderiaEmpleado.IdClaseGuarderia);
            ViewData["IdEmpleado"] = _context.Empleado
                .Where(e => e.IdEmpleado == claseGuarderiaEmpleado.IdEmpleado)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1,
                    Value = e.IdEmpleado.ToString()
                });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Nombre", claseGuarderiaEmpleado.IdEmpleado);
            return View(claseGuarderiaEmpleado);
        }

        // GET: ClaseGuarderiaEmpleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGuarderiaEmpleado = await _context.ClaseGuarderiaEmpleado.FindAsync(id);
            if (claseGuarderiaEmpleado == null)
            {
                return NotFound();
            }
            ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "IdClaseGuarderia", claseGuarderiaEmpleado.IdClaseGuarderia);
            ViewData["IdEmpleado"] = _context.Empleado
                 .Where(e => e.IdEmpleado == claseGuarderiaEmpleado.IdEmpleado)
                 .Select(e => new SelectListItem
                 {
                     Text = e.Nombre + " " + e.Apellido1,
                     Value = e.IdEmpleado.ToString()
                 });
            return View(claseGuarderiaEmpleado);
        }

        // POST: ClaseGuarderiaEmpleados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdClaseGuarderiaEmpleado,IdClaseGuarderia,IdEmpleado")] ClaseGuarderiaEmpleado claseGuarderiaEmpleado)
        {
            if (id != claseGuarderiaEmpleado.IdClaseGuarderiaEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claseGuarderiaEmpleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaseGuarderiaEmpleadoExists(claseGuarderiaEmpleado.IdClaseGuarderiaEmpleado))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                Thread.Sleep(1000);
                return RedirectToAction("Index", "ClasesGuarderia");
            }
            ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "IdClaseGuarderia", claseGuarderiaEmpleado.IdClaseGuarderia);
            ViewData["IdEmpleado"] = _context.Empleado
                .Where(e => e.IdEmpleado == claseGuarderiaEmpleado.IdEmpleado)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1,
                    Value = e.IdEmpleado.ToString()
                });
            return View(claseGuarderiaEmpleado);
        }

        // GET: ClaseGuarderiaEmpleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGuarderiaEmpleado = await _context.ClaseGuarderiaEmpleado
                .Include(c => c.IdClaseGuarderiaNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .FirstOrDefaultAsync(m => m.IdClaseGuarderiaEmpleado == id);
            if (claseGuarderiaEmpleado == null)
            {
                return NotFound();
            }

            return View(claseGuarderiaEmpleado);
        }

        // POST: ClaseGuarderiaEmpleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var claseGuarderiaEmpleado = await _context.ClaseGuarderiaEmpleado.FindAsync(id);
            _context.ClaseGuarderiaEmpleado.Remove(claseGuarderiaEmpleado);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction("Index", "ClasesGuarderia");
        }

        private bool ClaseGuarderiaEmpleadoExists(int id)
        {
            return _context.ClaseGuarderiaEmpleado.Any(e => e.IdClaseGuarderiaEmpleado == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(ClaseGuarderiaEmpleado claseGuarderiaEmpleado)
        {
            if (ModelState.IsValid)
            {
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditConAjax(ClaseGuarderiaEmpleado claseGuarderiaEmpleado)
        {
            if (ModelState.IsValid)
            {
                //_context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(ClaseGuarderiaEmpleado claseGuarderiaEmpleado)
        {
            ClaseGuarderia claseGuarderiaFind = _context.ClaseGuarderia.Find(claseGuarderiaEmpleado.IdClaseGuarderia);
            _context.ClaseGuarderia.Remove(claseGuarderiaFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2.Models;

namespace ProyectoFinal2020v2.Controllers
{
    public class ClasesGymController : Controller
    {
        private readonly GymContext _context;

        public ClasesGymController(GymContext context)
        {
            _context = context;
        }

        // GET: ClasesGym
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.ClaseGym
                .Include(c => c.IdActividadNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .Include(c => c.IdSalaNavigation);
            return View(await gymContext.ToListAsync());
        }

        // GET: ClasesGym/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGym = await _context.ClaseGym
                .Include(c => c.IdActividadNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .Include(c => c.IdSalaNavigation)
                .FirstOrDefaultAsync(m => m.IdClaseGym == id);
            if (claseGym == null)
            {
                return NotFound();
            }

            return View(claseGym);
        }

        // GET: ClasesGym/Create
        public IActionResult Create()
        {
            ViewData["IdActividad"] = new SelectList(_context.Actividad, "IdActividad", "Nombre");
            ViewData["IdEmpleado"] = _context.Empleado.Select(e => new SelectListItem
            {
                Text = e.Nombre + " " + e.Apellido1,
                Value = e.IdEmpleado.ToString()
            });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", dataTextField: ("Nombre" + " Apellido1"));
            ViewData["IdSala"] = new SelectList(_context.Sala, "IdSala", "NombreSala");
            return View();
        }


        // POST: ClasesGym/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdClaseGym,IdSala,Hora,Fecha,Cupo,IdActividad,IdEmpleado")] ClaseGym claseGym)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claseGym);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdActividad"] = new SelectList(_context.Actividad, "IdActividad", "Nombre", claseGym.IdActividad);
            ViewData["IdEmpleado"] = _context.Empleado
                .Where(e=>e.IdEmpleado==claseGym.IdEmpleado)
                .Select(e => new SelectListItem
            {
                Text = e.Nombre + " " + e.Apellido1,
                Value = e.IdEmpleado.ToString()
            });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Nombre"+"Apellido1", claseGym.IdEmpleado);
            ViewData["IdSala"] = new SelectList(_context.Sala, "IdSala", "NombreSala", claseGym.IdSala);
            return View(claseGym);
        }

        // GET: ClasesGym/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGym = await _context.ClaseGym.FindAsync(id);
            if (claseGym == null)
            {
                return NotFound();
            }
            ViewData["IdActividad"] = new SelectList(_context.Actividad, "IdActividad", "Nombre", claseGym.IdActividad);
            ViewData["IdEmpleado"] = _context.Empleado
                .Where(e => e.IdEmpleado == claseGym.IdEmpleado)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1,
                    Value = e.IdEmpleado.ToString()
                });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Apellido1", claseGym.IdEmpleado);
            ViewData["IdSala"] = new SelectList(_context.Sala, "IdSala", "NombreSala", claseGym.IdSala);
            return View(claseGym);
        }

        // POST: ClasesGym/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdClaseGym,IdSala,Hora,Fecha,Cupo,IdActividad,IdEmpleado")] ClaseGym claseGym)
        {
            if (id != claseGym.IdClaseGym)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claseGym);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaseGymExists(claseGym.IdClaseGym))
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
            ViewData["IdActividad"] = new SelectList(_context.Actividad, "IdActividad", "Nombre", claseGym.IdActividad);
            ViewData["IdEmpleado"] = _context.Empleado
                .Where(e => e.IdEmpleado == claseGym.IdEmpleado)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1,
                    Value = e.IdEmpleado.ToString()
                });
            //ViewData["IdEmpleado"] = new SelectList(_context.Empleado, "IdEmpleado", "Apellido1", claseGym.IdEmpleado);
            ViewData["IdSala"] = new SelectList(_context.Sala, "IdSala", "NombreSala", claseGym.IdSala);
            return View(claseGym);
        }

        // GET: ClasesGym/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGym = await _context.ClaseGym
                .Include(c => c.IdActividadNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .Include(c => c.IdSalaNavigation)
                .FirstOrDefaultAsync(m => m.IdClaseGym == id);
            if (claseGym == null)
            {
                return NotFound();
            }

            return View(claseGym);
        }

        // POST: ClasesGym/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var claseGym = await _context.ClaseGym.FindAsync(id);
            _context.ClaseGym.Remove(claseGym);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClaseGymExists(int id)
        {
            return _context.ClaseGym.Any(e => e.IdClaseGym == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(ClaseGym claseGym)
        {
            if (ModelState.IsValid)
            {
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditConAjax(ClaseGym claseGym)
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
        public ActionResult DeleteConAjax(ClaseGym claseGym)
        {
            ClaseGym claseGymFind = _context.ClaseGym.Find(claseGym.IdClaseGym);
            _context.ClaseGym.Remove(claseGymFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
    }
}

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
        public async Task<IActionResult> Create([Bind("IdClaseGym,IdSala,HoraInicio,HoraFinal,Fecha,Cupo,IdActividad,IdEmpleado,Estado")] ClaseGym claseGym)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claseGym);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
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
        public async Task<IActionResult> Edit(int id, [Bind("IdClaseGym,IdSala,HoraInicio,HoraFinal,Fecha,Cupo,IdActividad,IdEmpleado,Estado")] ClaseGym claseGym)
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
                Thread.Sleep(1000);
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
        public ActionResult Calendar()
        {
            List<Actividad> actividad = _context.Actividad.Where(a=>a.Estado=="Activo").ToList();
            List<Sala> sala = _context.Sala.Where(a => a.Estado == "Activo").ToList();
            List<Empleado> empleado = _context.Empleado.Where(a => a.Estado == "Activo").ToList();
            ViewData["Actividad"] = actividad;
            ViewData["Sala"] = sala;
            ViewData["Empleado"] = empleado;
            return View();
        }
        [HttpPost, ActionName("Guardar")]

        public ActionResult GuardarCalendar(ClaseGym claseGym)
        {
            if (ModelState.IsValid)
            {
                _context.ClaseGym.Add(claseGym);
                _context.SaveChanges();
                return Json(new { status = true });
            }

            return Json(new { status = false });
        }
        [HttpGet, ActionName("Listar")]
        public ActionResult ListaCalendar()
        {
            try
            {
                List<ClasesGymViewModel> clases = (List<ClasesGymViewModel>)(from cl in _context.ClaseGym
                                                                             join a in _context.Actividad on cl.IdActividad equals a.IdActividad
                                                                             join s in _context.Sala on cl.IdSala equals s.IdSala
                                                                             join e in _context.Empleado on cl.IdEmpleado equals e.IdEmpleado
                                                                             select new ClasesGymViewModel
                                                                             {
                                                                                 IdClaseGym = cl.IdClaseGym,
                                                                                 Fecha = cl.Fecha,
                                                                                 HoraInicio = cl.HoraInicio,
                                                                                 HoraFinal = cl.HoraFinal,
                                                                                 Cupo = cl.Cupo,
                                                                                 IdActividad = a.IdActividad,
                                                                                 NActividad = a.Nombre,
                                                                                 IdSala = s.IdSala,
                                                                                 NSala = s.NombreSala,
                                                                                 IdEmpleado = e.IdEmpleado,
                                                                                 NEmpleado = (e.Nombre.ToString() + e.Apellido1.ToString()),
                                                                                 Estado = cl.Estado
                                                                             }).ToList();
                return Json(new { status = true, data = clases });
            }
            catch (Exception)
            {
                return Json(new { status = false });
            }


        }
        [HttpDelete, ActionName("Borrar")]
        public ActionResult BorrarCalendar(ClaseGym claseGym)
        {
            ClaseGym claseFind = _context.ClaseGym.Find(claseGym.IdClaseGym);
            if (claseFind != null)
            {
                _context.ClaseGym.Remove(claseFind);
                _context.SaveChanges();
                return Json(new { status = true });
            }
            return Json(new { status = false });

        }
        [HttpPost, ActionName("Modificar")]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCalendar(ClaseGym claseGym)
        {

            if (ModelState.IsValid)
            {
                _context.Entry(claseGym).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
    }
}

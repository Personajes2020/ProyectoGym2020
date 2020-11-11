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
    public class ClasesGuarderiaController : Controller
    {
        private readonly GymContext _context;
        public int xValor=0;

        public ClasesGuarderiaController(GymContext context)
        {
            _context = context;
        }

        // GET: ClasesGuarderia
        public/* async Task<*/IActionResult/*>*/ Index()
        {
            var claseguarderiaVModel = new ClaseGuarderiaViewModel();
            var clases = _context.ClaseGuarderia.ToList();
            var empleado = _context.ClaseGuarderiaEmpleado.ToList();

            claseguarderiaVModel.ClaseGuarderia = clases;
            claseguarderiaVModel.ClaseGuarderiaEmpleado = empleado;

            List<Empleado> empleadolista = _context.Empleado.ToList();
            ViewData["Empleados"] = empleadolista;

            return View(claseguarderiaVModel);/*await _context.ClaseGuarderia.ToListAsync()*/
        }

        // GET: ClasesGuarderia/Details/5
        public /*async Task<*/IActionResult/*> */Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ClaseGuarderiaViewModel claseGuarderiaViewModel = new ClaseGuarderiaViewModel();
            var claseGuarderia = _context.ClaseGuarderia
                .Where(m => m.IdClaseGuarderia == id).ToList();
            if (claseGuarderia == null)
            {
                return NotFound();
            }
            var empleados = _context.ClaseGuarderiaEmpleado
                         .Where(e => e.IdClaseGuarderia == id).ToList();

            claseGuarderiaViewModel.ClaseGuarderia = claseGuarderia;
            claseGuarderiaViewModel.ClaseGuarderiaEmpleado = empleados;

            List<Empleado> empleadolista = _context.Empleado.ToList();
            ViewData["Empleados"] = empleadolista;

            return View(claseGuarderiaViewModel);
        }

        // GET: ClasesGuarderia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClasesGuarderia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdClaseGuarderia,HoraInicio,HoraFin,Fecha,Cupo,Duracion,Estado")] ClaseGuarderia claseGuarderia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claseGuarderia);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            return View(claseGuarderia);
        }

        // GET: ClasesGuarderia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGuarderia = await _context.ClaseGuarderia.FindAsync(id);
            if (claseGuarderia == null)
            {
                return NotFound();
            }
            return View(claseGuarderia);
        }

        // POST: ClasesGuarderia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdClaseGuarderia,HoraInicio,HoraFin,Fecha,Cupo,Duracion,Estado")] ClaseGuarderia claseGuarderia)
        {
            if (id != claseGuarderia.IdClaseGuarderia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claseGuarderia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaseGuarderiaExists(claseGuarderia.IdClaseGuarderia))
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
            return View(claseGuarderia);
        }

        // GET: ClasesGuarderia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claseGuarderia = await _context.ClaseGuarderia
                .FirstOrDefaultAsync(m => m.IdClaseGuarderia == id);
            if (claseGuarderia == null)
            {
                return NotFound();
            }

            return View(claseGuarderia);
        }

        // POST: ClasesGuarderia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var claseGuarderia = await _context.ClaseGuarderia.FindAsync(id);
            _context.ClaseGuarderia.Remove(claseGuarderia);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction(nameof(Index));
        }

        private bool ClaseGuarderiaExists(int id)
        {
            return _context.ClaseGuarderia.Any(e => e.IdClaseGuarderia == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(ClaseGuarderia claseGuarderia)
        {
            if (ModelState.IsValid)
            {
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditConAjax(ClaseGuarderia claseGuarderia)
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
        public ActionResult DeleteConAjax(ClaseGuarderia claseGuarderia)
        {
            ClaseGuarderia claseGuarderiaFind = _context.ClaseGuarderia.Find(claseGuarderia.IdClaseGuarderia);
            _context.ClaseGuarderia.Remove(claseGuarderiaFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
        public ActionResult Calendar()
        {
            //List<Actividad> actividad = _context.Actividad.Where(a => a.Estado == "Activo").ToList();
            //List<Sala> sala = _context.Sala.Where(a => a.Estado == "Activo").ToList();
            List<Empleado> empleado = _context.Empleado.Where(a => a.Estado == "Activo").ToList();
            //ViewData["Actividad"] = actividad;
            //ViewData["Sala"] = sala;
            ViewData["Empleado"] = empleado;
            return View();
        }
        [HttpPost, ActionName("Guardar")]
        public ActionResult GuardarCalendar(ClaseGuarderiaCalendarViewModel claseGuarderiVm)
        {
            if (ModelState.IsValid)
            {
                
                    ClaseGuarderia claseguarderia = new ClaseGuarderia
                    {
                        Fecha = claseGuarderiVm.ClaseGuarderia.Fecha,
                        HoraInicio = claseGuarderiVm.ClaseGuarderia.HoraInicio,
                        HoraFin = claseGuarderiVm.ClaseGuarderia.HoraFin,
                        Cupo = claseGuarderiVm.ClaseGuarderia.Cupo,
                        Estado = claseGuarderiVm.ClaseGuarderia.Estado
                    };
                    _context.Add(claseguarderia);
               
                _context.SaveChanges();

                var idclaseGuarderia = _context.ClaseGuarderia.Max(cl => cl.IdClaseGuarderia);
                
                foreach (ClaseGuarderiaEmpleado item2 in claseGuarderiVm.ClaseGuarderiaEmpleado)
                {
                    ClaseGuarderiaEmpleado claseguarderiaEmpl = new ClaseGuarderiaEmpleado
                    {
                         IdClaseGuarderia = idclaseGuarderia,
                         IdEmpleado = item2.IdEmpleado
                    };
                    _context.Add(claseguarderiaEmpl);
                }
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
                //var claseguarderiaVModel = new ClaseGuarderiaListarViewModel();
                var clases = _context.ClaseGuarderia.Where(x=>x.Estado=="Activo").ToList();

                List<ClaseGuarderia> clases1 = (List<ClaseGuarderia>)
                    (from cl in _context.ClaseGuarderia 
                     select new ClaseGuarderia
                     {
                         IdClaseGuarderia = cl.IdClaseGuarderia,
                         Fecha = cl.Fecha,
                         HoraInicio = cl.HoraInicio,
                         HoraFin = cl.HoraFin,
                         Cupo = cl.Cupo,
                         Estado = cl.Estado,

                     }).ToList();

                return Json(new { status = true, data = clases1 });
            }
            catch (Exception)
            {
                return Json(new { status = false });
            }


        }
        [HttpDelete, ActionName("Borrar")]
        public ActionResult BorrarCalendar(ClaseGuarderiaCalendarViewModel claseguar)
        {
            var borrarclase = _context.ClaseGuarderiaEmpleado
                .Where(cl => cl.IdClaseGuarderia == claseguar.ClaseGuarderia.IdClaseGuarderia).ToList();
            foreach (ClaseGuarderiaEmpleado item in borrarclase)
            {
                _context.Remove(item);

            }
            _context.SaveChanges();
            ClaseGuarderia claseFind = _context.ClaseGuarderia.Find(claseguar.ClaseGuarderia.IdClaseGuarderia);
            if (claseFind != null)
            {
                _context.Remove(claseFind);
                _context.SaveChanges();
                return Json(new { status = true });
            }
            return Json(new { status = false });

        }
        [HttpPost, ActionName("Modificar")]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCalendar(ClaseGuarderiaCalendarViewModel claseguar)
        {

            if (ModelState.IsValid)
            {
                _context.Entry(claseguar).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
    }
}

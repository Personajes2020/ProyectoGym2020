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
    public class MatriculasGuarderiaController : Controller
    {
        private readonly GymContext _context;

        public MatriculasGuarderiaController(GymContext context)
        {
            _context = context;
        }

        // GET: MatriculasGuarderia
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.MatriculaGuarderia.Include(m => m.IdClaseGuarderiaNavigation).Include(m => m.IdHijoNavigation);
            return View(await gymContext.ToListAsync());
        }
        public async Task<IActionResult> IndexClase1()
        {
            //ClaseGym claseGym = new ClaseGym();
           var gymContext =await _context.ClaseGuarderia.ToListAsync();
            return View("SelectCreateClase", gymContext);

        }
        public async Task<IActionResult> IndexClase2()
        {
            //ClaseGym claseGym = new ClaseGym();
            var gymContext = await _context.ClaseGuarderia.ToListAsync();
            return View("SelectEditClase", gymContext);

        }

        // GET: MatriculasGuarderia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaGuarderia = await _context.MatriculaGuarderia
                .Include(m => m.IdClaseGuarderiaNavigation)
                .Include(m => m.IdHijoNavigation)
                .FirstOrDefaultAsync(m => m.IdMatricula == id);
            if (matriculaGuarderia == null)
            {
                return NotFound();
            }

            return View(matriculaGuarderia);
        }

        // GET: MatriculasGuarderia/Create
        public IActionResult Create()
        {
            if (TempData.ContainsKey("IdClase1"))
            {
                TempData["IdClaseGuarderia"] = (int)TempData["IdClase1"];
            }
            ViewData["IdHijo"] = _context.Hijo.Select(h => new SelectListItem
            {
                Text = h.Nombre + " " + h.Apellido1 ,
                Value = h.IdHijo.ToString()
            });
            //ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "Estado");
            //ViewData["IdHijo"] = new SelectList(_context.Hijo, "IdHijo", "Apellido1");
            return View();
        }

        // POST: MatriculasGuarderia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMatricula,IdClaseGuarderia,IdHijo")] MatriculaGuarderia matriculaGuarderia)
        {
            matriculaGuarderia.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var validarCliente = _context.MatriculaGuarderia.Any(m => m.IdHijo.Equals(matriculaGuarderia.IdHijo));
                if (validarCliente)
                {
                    ModelState.AddModelError("IdHijo", "El hijo que quiere ingresar ya esta matriculado");
                    Thread.Sleep(3500);
                    return View("create");
                }
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try {
                        _context.Add(matriculaGuarderia);
                        var restarCupo = from clas in _context.ClaseGuarderia
                                         where (clas.IdClaseGuarderia == matriculaGuarderia.IdClaseGuarderia)
                                         select clas;

                        foreach (var item in restarCupo)
                        {
                            if (item.Cupo == 0)
                            {
                                ModelState.AddModelError("", errorMessage: "La clase seleccionada ya no quedan cupo disponible!");
                                return View("Create");
                            }
                            item.Cupo = ((int)(item.Cupo - 1));
                            _context.ClaseGuarderia.Update(item);
                        }
                        await _context.SaveChangesAsync();
                        dbContextTransaction.Commit();
                    }
                    catch {
                         dbContextTransaction.Rollback();
                    }
                }

                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            TempData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "Estado", matriculaGuarderia.IdClaseGuarderia);
            ViewData["IdHijo"] = _context.Hijo
                 .Where(h => h.IdHijo == matriculaGuarderia.IdHijo)
                 .Select(h => new SelectListItem
                 {
                     Text = h.Nombre + " " + h.Apellido1 ,
                     Value = h.IdHijo.ToString()
                 });
            return View(matriculaGuarderia);
        }

        // GET: MatriculasGuarderia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaGuarderia = await _context.MatriculaGuarderia.FindAsync(id);
            if (matriculaGuarderia == null)
            {
                return NotFound();
            }
            if (TempData["IdClase2"] == null)
            {
                ViewData["IdClaseGuarderia"] = matriculaGuarderia.IdClaseGuarderia;
            }
            else
            {
                ViewData["IdClaseGuarderia"] = (int)TempData["IdClase2"];
            }
            TempData["IdDeMatricula"] = id;
            //ViewData["IdClaseGuarderia"] = new SelectList(_context.ClaseGuarderia, "IdClaseGuarderia", "Estado", matriculaGuarderia.IdClaseGuarderia);
            //ViewData["IdHijo"] = new SelectList(_context.Hijo, "IdHijo", "Apellido1", matriculaGuarderia.IdHijo);
            ViewData["IdHijo"] = _context.Hijo
                 .Where(h => h.IdHijo == matriculaGuarderia.IdHijo)
                 .Select(h => new SelectListItem
                 {
                     Text = h.Nombre + " " + h.Apellido1,
                     Value = h.IdHijo.ToString()
                 });
            return View(matriculaGuarderia);
        }

        // POST: MatriculasGuarderia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMatricula,IdClaseGuarderia,IdHijo")] MatriculaGuarderia matriculaGuarderia)
        {
            if (id != matriculaGuarderia.IdMatricula)
            {
                return NotFound();
            }
            matriculaGuarderia.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var cambiarCupo = _context.MatriculaGuarderia
                            .Where(m => m.IdMatricula == matriculaGuarderia.IdMatricula && m.IdClaseGuarderia == matriculaGuarderia.IdClaseGuarderia)
                            .Select(m=>m);
                        if (cambiarCupo!=null)
                        {
                            var clasenew = _context.ClaseGuarderia
                                .Where(cl => cl.IdClaseGuarderia == matriculaGuarderia.IdClaseGuarderia);
                            var clasbefore = _context.MatriculaGuarderia
                                .Where(m => m.IdMatricula == matriculaGuarderia.IdMatricula)
                                .Select(m => m.IdClaseGuarderia)
                                .FirstOrDefault();
                            var clase2 = _context.ClaseGuarderia.Where(cl => cl.IdClaseGuarderia == clasbefore);
                            foreach (var item1 in clasenew)
                            {
                                item1.Cupo = ((int)(item1.Cupo - 1));
                                _context.Update(item1);
                            }
                            foreach (var item2 in clase2)
                            {
                                item2.Cupo = ((int)(item2.Cupo + 1));
                                _context.Update(item2);
                            }
                            _context.Update(matriculaGuarderia);
                            dbContextTransaction.Commit();
                            await _context.SaveChangesAsync();
                        }
                    
                    } catch (DbUpdateConcurrencyException)
                    {
                        dbContextTransaction.Rollback();
                        if (!MatriculaGuarderiaExists(matriculaGuarderia.IdMatricula))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            if (TempData.ContainsKey("IdClase2"))
            {
                ViewData["IdClaseGuarderia"] = (int)TempData["IdClase2"];
            }
             ViewData["IdHijo"] = _context.Hijo
                 .Where(h => h.IdHijo == matriculaGuarderia.IdHijo)
                 .Select(h => new SelectListItem
                 {
                     Text = h.Nombre + " " + h.Apellido1,
                     Value = h.IdHijo.ToString()
                 });
            return View(matriculaGuarderia);
        }

        // GET: MatriculasGuarderia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaGuarderia = await _context.MatriculaGuarderia
                .Include(m => m.IdClaseGuarderiaNavigation)
                .Include(m => m.IdHijoNavigation)
                .FirstOrDefaultAsync(m => m.IdMatricula == id);
            if (matriculaGuarderia == null)
            {
                return NotFound();
            }

            return View(matriculaGuarderia);
        }

        // POST: MatriculasGuarderia/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var matriculaGuarderia = await _context.MatriculaGuarderia.FindAsync(id);
        //    _context.MatriculaGuarderia.Remove(matriculaGuarderia);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool MatriculaGuarderiaExists(int id)
        {
            return _context.MatriculaGuarderia.Any(e => e.IdMatricula == id);
        }
        public IActionResult SelectA(int id)
        {
            TempData["IdClase1"] = id;
            return RedirectToAction("Create");
        }
        public IActionResult SelectB(int id)
        {
            TempData["IdClase2"] = id;
            int ids = (int)TempData["IdDeMatricula"];
            return RedirectToAction("Edit", new { id = ids });
        }
        //Validar para usar SweetAlert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVali(MatriculaGuarderia matriculaGuarderia)
        {
            matriculaGuarderia.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var validarHijo = _context.MatriculaGuarderia.Any(m => m.IdHijo.Equals(matriculaGuarderia.IdHijo));
                if (validarHijo)
                {
                    //ModelState.AddModelError("IdCliente", "El cliente que quiere ingresar ya esta matriculado");
                    return Json(new { result = false });
                }
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        public ActionResult EditVali(MatriculaGuarderia matriculaGuarderia)
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
        public ActionResult DeleteVali(MatriculaGuarderia matriculaGuarderia)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    MatriculaGuarderia matriculaFind = /*await*/ _context.MatriculaGuarderia.Find/*Async*/(matriculaGuarderia.IdMatricula);
                    var desconCupo = _context.ClaseGuarderia.Where(cl => cl.IdClaseGuarderia == matriculaFind.IdClaseGuarderia);
                    foreach (var item in desconCupo)
                    {
                        item.Cupo = ((int)(item.Cupo + 1));
                        _context.Update(item);

                    }
                    _context.MatriculaGuarderia.Remove(matriculaFind);
                    dbContextTransaction.Commit();
                    _context.SaveChanges();

                }
                catch
                {
                    dbContextTransaction.Rollback();
                    //return Json(new { result = false });
                }

            }
            return Json(new { result = true });
        }
    }
}

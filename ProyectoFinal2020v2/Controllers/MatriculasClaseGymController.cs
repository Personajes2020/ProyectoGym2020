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
    public class MatriculasClaseGymController : Controller
    {
        private readonly GymContext _context;

        public MatriculasClaseGymController(GymContext context)
        {
            _context = context;
        }

        // GET: MatriculasClaseGym
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.MatriculaClaseGym.Include(m => m.IdClaseGymNavigation).Include(m => m.IdClienteNavigation);
            return View(await gymContext.ToListAsync());
        }
        public async Task<IActionResult> IndexClase()
        {
            //ClaseGym claseGym = new ClaseGym();
            var gymContext = _context.ClaseGym
                .Include(c => c.IdActividadNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .Include(c => c.IdSalaNavigation);
            return View("SelectClase", await gymContext.ToListAsync());
           
        }

        // GET: MatriculasClaseGym/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaClaseGym = await _context.MatriculaClaseGym
                .Include(m => m.IdClaseGymNavigation)
                .Include(m => m.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdMatriculaGym == id);
            if (matriculaClaseGym == null)
            {
                return NotFound();
            }

            return View(matriculaClaseGym);
        }

        // GET: MatriculasClaseGym/Create
        public IActionResult Create()
        {
            if (TempData.ContainsKey("IdClase"))
            {
                ViewData["IdClaseGym"] = (int)TempData["IdClase"];
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1");
            return View();
        }

        // POST: MatriculasClaseGym/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMatriculaGym,IdCliente,IdClaseGym,Fecha")] MatriculaClaseGym matriculaClaseGym)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matriculaClaseGym);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClaseGym"] = new SelectList(_context.ClaseGym, "IdClaseGym", "Estado", matriculaClaseGym.IdClaseGym);
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", matriculaClaseGym.IdCliente);
            return View(matriculaClaseGym);
        }

        // GET: MatriculasClaseGym/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaClaseGym = await _context.MatriculaClaseGym.FindAsync(id);
            if (matriculaClaseGym == null)
            {
                return NotFound();
            }
            ViewData["IdClaseGym"] = new SelectList(_context.ClaseGym, "IdClaseGym", "Estado", matriculaClaseGym.IdClaseGym);
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", matriculaClaseGym.IdCliente);
            return View(matriculaClaseGym);
        }

        // POST: MatriculasClaseGym/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMatriculaGym,IdCliente,IdClaseGym,Fecha")] MatriculaClaseGym matriculaClaseGym)
        {
            if (id != matriculaClaseGym.IdMatriculaGym)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matriculaClaseGym);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatriculaClaseGymExists(matriculaClaseGym.IdMatriculaGym))
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
            ViewData["IdClaseGym"] = new SelectList(_context.ClaseGym, "IdClaseGym", "Estado", matriculaClaseGym.IdClaseGym);
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", matriculaClaseGym.IdCliente);
            return View(matriculaClaseGym);
        }

        // GET: MatriculasClaseGym/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaClaseGym = await _context.MatriculaClaseGym
                .Include(m => m.IdClaseGymNavigation)
                .Include(m => m.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdMatriculaGym == id);
            if (matriculaClaseGym == null)
            {
                return NotFound();
            }

            return View(matriculaClaseGym);
        }

        // POST: MatriculasClaseGym/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matriculaClaseGym = await _context.MatriculaClaseGym.FindAsync(id);
            _context.MatriculaClaseGym.Remove(matriculaClaseGym);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatriculaClaseGymExists(int id)
        {
            return _context.MatriculaClaseGym.Any(e => e.IdMatriculaGym == id);
        }
        public IActionResult SelectB(int id)
        {
            TempData["IdClase"] = id;
            return RedirectToAction("Create");
        }
    }
}

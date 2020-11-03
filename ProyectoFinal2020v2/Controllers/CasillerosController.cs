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
    public class CasillerosController : Controller
    {
        private readonly GymContext _context;

        public CasillerosController(GymContext context)
        {
            _context = context;
        }

        // GET: Casilleros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casillero.ToListAsync());
        }

        // GET: Casilleros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casillero = await _context.Casillero
                .FirstOrDefaultAsync(m => m.IdCasillero == id);
            if (casillero == null)
            {
                return NotFound();
            }

            return View(casillero);
        }

        // GET: Casilleros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casilleros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCasillero,Descripcion")] Casillero casillero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casillero);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            return View(casillero);
        }

        // GET: Casilleros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casillero = await _context.Casillero.FindAsync(id);
            if (casillero == null)
            {
                return NotFound();
            }
            return View(casillero);
        }

        // POST: Casilleros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCasillero,Descripcion")] Casillero casillero)
        {
            if (id != casillero.IdCasillero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casillero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasilleroExists(casillero.IdCasillero))
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
            return View(casillero);
        }

        // GET: Casilleros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casillero = await _context.Casillero
                .FirstOrDefaultAsync(m => m.IdCasillero == id);
            if (casillero == null)
            {
                return NotFound();
            }

            return View(casillero);
        }

        // POST: Casilleros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casillero = await _context.Casillero.FindAsync(id);
            _context.Casillero.Remove(casillero);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction(nameof(Index));
        }

        private bool CasilleroExists(int id)
        {
            return _context.Casillero.Any(e => e.IdCasillero == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Casillero casillero)
        {
            if (ModelState.IsValid)
            {
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Casillero casillero)
        {

            Casillero casilleroFind = _context.Casillero.Find(casillero.IdCasillero);
            _context.Casillero.Remove(casilleroFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
        public ActionResult EditConAjax(Casillero casillero)
        {
            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
    }
}

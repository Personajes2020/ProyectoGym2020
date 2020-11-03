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
    public class HijosController : Controller
    {
        private readonly GymContext _context;

        public HijosController(GymContext context)
        {
            _context = context;
        }

        // GET: Hijos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hijo.ToListAsync());
        }

        // GET: Hijos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hijo = await _context.Hijo
                .FirstOrDefaultAsync(m => m.IdHijo == id);
            if (hijo == null)
            {
                return NotFound();
            }

            return View(hijo);
        }

        // GET: Hijos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hijos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHijo,Identificacion,Nombre,Apellido1,Apellido2,FechaDeNac")] Hijo hijo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hijo);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            return View(hijo);
        }

        // GET: Hijos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hijo = await _context.Hijo.FindAsync(id);
            if (hijo == null)
            {
                return NotFound();
            }
            return View(hijo);
        }

        // POST: Hijos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHijo,Identificacion,Nombre,Apellido1,Apellido2,FechaDeNac")] Hijo hijo)
        {
            if (id != hijo.IdHijo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hijo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HijoExists(hijo.IdHijo))
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
            return View(hijo);
        }

        // GET: Hijos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hijo = await _context.Hijo
                .FirstOrDefaultAsync(m => m.IdHijo == id);
            if (hijo == null)
            {
                return NotFound();
            }

            return View(hijo);
        }

        // POST: Hijos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hijo = await _context.Hijo.FindAsync(id);
            _context.Hijo.Remove(hijo);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction(nameof(Index));
        }

        private bool HijoExists(int id)
        {
            return _context.Hijo.Any(e => e.IdHijo == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Hijo hijo)
        {
            if (ModelState.IsValid)
            {
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Hijo hijo)
        {

            Hijo hijoFind = _context.Hijo.Find(hijo.IdHijo);
            _context.Hijo.Remove(hijoFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
        public ActionResult EditConAjax(Hijo hijo)
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

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
    public class MonederosController : Controller
    {
        private readonly GymContext _context;

        public MonederosController(GymContext context)
        {
            _context = context;
        }

        // GET: Monederos
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.Monedero.Include(m => m.IdClienteNavigation);
            return View(await gymContext.ToListAsync());
        }

        // GET: Monederos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monedero = await _context.Monedero
                .Include(m => m.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdMonedero == id);
            if (monedero == null)
            {
                return NotFound();
            }

            return View(monedero);
        }

        // GET: Monederos/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = _context.Cliente
               .Where(e => e.Estado == "Activo")
               .Select(e => new SelectListItem
               {
                   Text = e.Nombre + " " + e.Apellido1,
                   Value = e.IdCliente.ToString()
               });
            //ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1");
            return View();
        }

        // POST: Monederos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMonedero,IdCliente,Saldo")] Monedero monedero)
        {
            if (ModelState.IsValid)
            {
                var validarexist = _context.Monedero.Where(m => m.IdCliente == monedero.IdCliente).FirstOrDefault();
                if (validarexist!=null)
                {
                    ModelState.AddModelError("IdCliente", "El cliente ya cuenta con un monedero.");
                    return View(monedero);
                }
                _context.Add(monedero);
                await _context.SaveChangesAsync();
                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdCliente"] = _context.Cliente
               .Where(e => e.IdCliente == monedero.IdCliente)
               .Select(e => new SelectListItem
               {
                   Text = e.Nombre + " " + e.Apellido1,
                   Value = e.IdCliente.ToString()
               });
            //ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", monedero.IdCliente);
            return View(monedero);
        }

        // GET: Monederos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monedero = await _context.Monedero.FindAsync(id);
            if (monedero == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", monedero.IdCliente);
            return View(monedero);
        }

        // POST: Monederos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMonedero,IdCliente,Saldo")] Monedero monedero)
        {
            if (id != monedero.IdMonedero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monedero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonederoExists(monedero.IdMonedero))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "IdCliente", "Apellido1", monedero.IdCliente);
            return View(monedero);
        }

        // GET: Monederos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monedero = await _context.Monedero
                .Include(m => m.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdMonedero == id);
            if (monedero == null)
            {
                return NotFound();
            }

            return View(monedero);
        }

        // POST: Monederos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var monedero = await _context.Monedero.FindAsync(id);
            _context.Monedero.Remove(monedero);
            await _context.SaveChangesAsync();
            Thread.Sleep(2000);
            return RedirectToAction(nameof(Index));
        }

        private bool MonederoExists(int id)
        {
            return _context.Monedero.Any(e => e.IdMonedero == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Monedero monedero)
        {
            
            Monedero monederoFind = _context.Monedero.Find(monedero.IdMonedero);
            _context.Monedero.Remove(monederoFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Monedero monedero)
        {
            if (ModelState.IsValid)
            {
                var validarexist = _context.Monedero.Where(m => m.IdCliente == monedero.IdCliente).FirstOrDefault();

                if (validarexist != null)
                {
                    return Json(new { result = false });
                }
                return Json(new { result = true }); 
            }
            return Json(new { result = false }); 
        }
        public ActionResult EditConAjax(Monedero monedero)
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

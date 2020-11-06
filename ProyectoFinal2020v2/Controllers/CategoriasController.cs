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
    public class CategoriasController : Controller
    {
        private readonly GymContext _context;

        public CategoriasController(GymContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categoria.ToListAsync());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCategoria,Codigo,Nombre,Descripcion")] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                var validacionCodigo = _context.Categoria.Any(c => c.Codigo.Equals(categoria.Codigo));

                if (validacionCodigo)
                {
                    ModelState.AddModelError("Codigo", "Ya se encuentra registrado");

                    return View("Create");
                }
                _context.Add(categoria);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);

        }


        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCategoria,Codigo,Nombre,Descripcion")] Categoria categoria)
        {
            if (id != categoria.IdCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var validacionCodigo = _context.Categoria.Any(c => c.Codigo.Equals(categoria.Codigo));

                if (validacionCodigo)
                {
                    ModelState.AddModelError("Codigo", "Ya se encuentra registrado");

                    return View("Edit");
                }
                try
                {
                    _context.Update(categoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaExists(categoria.IdCategoria))
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
            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.IdCategoria == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Categoria categoria)
        {
                if (ModelState.IsValid)
                {
                    var validacionCodigo = _context.Categoria.Any(c => c.Codigo.Equals(categoria.Codigo));

                    if (validacionCodigo)
                    {
                        ModelState.AddModelError("Codigo", "Ya se encuentra registrado");

                        return View("Create");
                    }

                    return Json(new { result = true, });
            }
            return Json(new { result = false });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Categoria categoria)
        {

            Categoria categoriaFind = _context.Categoria.Find(categoria.IdCategoria);
            _context.Categoria.Remove(categoriaFind);
            _context.SaveChanges();
            return Json(new { result = true, });

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditConAjax(Categoria categoria)
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

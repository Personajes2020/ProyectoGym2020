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
    public class ClientesController : Controller
    {
        private readonly GymContext _context;

        public ClientesController(GymContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.Cliente.Include(c => c.IdCasilleroNavigation).Include(c => c.IdTarifaNavigation);
            return View(await gymContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.IdCasilleroNavigation)
                .Include(c => c.IdTarifaNavigation)
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            
            List<Tarifa> tari = _context.Tarifa.ToList();         
            TempData["Tarifa"] = tari;

            List<Casillero> casi = _context.Casillero.ToList();
            TempData["Casillero"] = casi;


            //ViewData["IdCasillero"] = new SelectList(_context.Casillero, "IdCasillero", "IdCasillero");
            //ViewData["IdTarifa"] = new SelectList(_context.Tarifa, "IdTarifa", "IdTarifa");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente,Identificacion,Nombre,Apellido1,Apellido2,FechaNac,Telefono,Direccion,Email,Estado,Sexo,IdCasillero,IdTarifa,FechaRenovacion")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
               
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCasillero"] = new SelectList(_context.Casillero, "IdCasillero", "IdCasillero", cliente.IdCasillero);
            ViewData["IdTarifa"] = new SelectList(_context.Tarifa, "IdTarifa", "IdTarifa", cliente.IdTarifa);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //List<Tarifa> tari = _context.Tarifa.ToList();
            //TempData["Tarifa"] = tari;

            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            List<Tarifa> tari = _context.Tarifa.ToList();
            TempData["Tarifa"] = tari;
            List<Casillero> casi = _context.Casillero.ToList();
            TempData["Casillero"] = casi;
            //TempData["IdCasillero"] = new SelectList(_context.Casillero, "IdCasillero", "IdCasillero", cliente.IdCasillero);
            //TempData["IdTarifa"] = new SelectList(_context.Tarifa, "IdTarifa", "IdTarifa", cliente.IdTarifa);
            ViewData["IdCasillero"] = new SelectList(_context.Casillero, "IdCasillero", "IdCasillero", cliente.IdCasillero);
            ViewData["IdTarifa"] = new SelectList(_context.Tarifa, "IdTarifa", "IdTarifa", cliente.IdTarifa);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCliente,Identificacion,Nombre,Apellido1,Apellido2,FechaNac,Telefono,Direccion,Email,Estado,Sexo,IdCasillero,IdTarifa,FechaRenovacion")] Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.IdCliente))
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
            ViewData["IdCasillero"] = new SelectList(_context.Casillero, "IdCasillero", "IdCasillero", cliente.IdCasillero);
            ViewData["IdTarifa"] = new SelectList(_context.Tarifa, "IdTarifa", "IdTarifa", cliente.IdTarifa);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.IdCasilleroNavigation)
                .Include(c => c.IdTarifaNavigation)
                .FirstOrDefaultAsync(m => m.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.IdCliente == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax(Cliente cliente)
        {
                if (ModelState.IsValid)
                {
                    return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Cliente cliente)
        {

            Cliente clienteFind = _context.Cliente.Find(cliente.IdCliente);
            _context.Cliente.Remove(clienteFind);
            _context.SaveChanges();
            return Json(new { result = true, });
        }
        public ActionResult EditConAjax(Cliente cliente)
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

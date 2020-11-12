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
    public class DetallesPedidosController : Controller
    {
        private readonly GymContext _context;

        public DetallesPedidosController(GymContext context)
        {
            _context = context;
        }

        // GET: DetallesPedidos
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.DetallesPedido.Include(d => d.IdCategoriaNavigation).Include(d => d.IdPedidoNavigation).Include(d => d.IdProductoNavigation).Include(d => d.IdProveedorNavigation);
            return View(await gymContext.ToListAsync());
        }

        // GET: DetallesPedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallesPedido = await _context.DetallesPedido
                .Include(d => d.IdCategoriaNavigation)
                .Include(d => d.IdPedidoNavigation)
                .Include(d => d.IdProductoNavigation)
                .Include(d => d.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.IdDetalles == id);
            if (detallesPedido == null)
            {
                return NotFound();
            }

            return View(detallesPedido);
        }

        // GET: DetallesPedidos/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Codigo");
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "Estado");
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Codigo");
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Descripcion");
            return View();
        }

        // POST: DetallesPedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDetalles,IdPedido,IdProducto,IdCategoria,IdProveedor,PrecioUnidad,UnidadesSolicitadas,FechaCaducidad")] DetallesPedido detallesPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detallesPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Codigo", detallesPedido.IdCategoria);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "Estado", detallesPedido.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Codigo", detallesPedido.IdProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Descripcion", detallesPedido.IdProveedor);
            return View(detallesPedido);
        }

        // GET: DetallesPedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallesPedido = await _context.DetallesPedido.FindAsync(id);
            if (detallesPedido == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Codigo", detallesPedido.IdCategoria);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "Estado", detallesPedido.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Codigo", detallesPedido.IdProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Descripcion", detallesPedido.IdProveedor);
            return View(detallesPedido);
        }

        // POST: DetallesPedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetalles,IdPedido,IdProducto,IdCategoria,IdProveedor,PrecioUnidad,UnidadesSolicitadas,FechaCaducidad")] DetallesPedido detallesPedido)
        {
            if (id != detallesPedido.IdDetalles)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detallesPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetallesPedidoExists(detallesPedido.IdDetalles))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "Codigo", detallesPedido.IdCategoria);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "Estado", detallesPedido.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Codigo", detallesPedido.IdProducto);
            ViewData["IdProveedor"] = new SelectList(_context.Proveedor, "IdProveedor", "Descripcion", detallesPedido.IdProveedor);
            return View(detallesPedido);
        }

        // GET: DetallesPedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallesPedido = await _context.DetallesPedido
                .Include(d => d.IdCategoriaNavigation)
                .Include(d => d.IdPedidoNavigation)
                .Include(d => d.IdProductoNavigation)
                .Include(d => d.IdProveedorNavigation)
                .FirstOrDefaultAsync(m => m.IdDetalles == id);
            if (detallesPedido == null)
            {
                return NotFound();
            }

            return View(detallesPedido);
        }

        // POST: DetallesPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detallesPedido = await _context.DetallesPedido.FindAsync(id);
            _context.DetallesPedido.Remove(detallesPedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetallesPedidoExists(int id)
        {
            return _context.DetallesPedido.Any(e => e.IdDetalles == id);
        }
    }
}

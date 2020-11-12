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
    public class PedidosController : Controller
    {
        private readonly GymContext _context;

        public PedidosController(GymContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedido.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPedido,FechaCompra,FechaLlegada,Estado,Importe,Descripcion")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPedido,Descripcion")] Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.IdPedido))
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
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.IdPedido == id);
        }
        public IActionResult PedidoPro()
        {
            List<Producto> product = _context.Producto.ToList();
            TempData["Produc"] = product;

            return View();
        }
        public IActionResult Guardar(PedidoViewModel pedido)
        {

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Pedido pedi = new Pedido { FechaCompra = pedido.FechaCompra, FechaLlegada = pedido.FechaLLegada, Estado = "Pendiente", Importe = pedido.Total };
                    _context.Add(pedi);
                    _context.SaveChanges();

                    foreach (DetallesPedido item in pedido.detalles)
                    {
                        DetallesPedido detalle = new DetallesPedido
                        {
                            IdPedido = pedi.IdPedido,
                            IdCategoria = item.IdCategoria,
                            IdProducto = item.IdProducto,
                            IdProveedor = item.IdProveedor,
                            UnidadesSolicitadas = item.UnidadesSolicitadas,
                            PrecioUnidad = item.PrecioUnidad,
                            FechaCaducidad = item.FechaCaducidad

                        };
                        _context.Add(detalle);
                    }
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Cancelar(int id)
        {
            var pedi = (from a in _context.Pedido
                        where a.IdPedido == id
                        select a).FirstOrDefault();
            pedi.Estado = "Cancelado";
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Recibir(int id)
        {
            var pedi = (from p in _context.Pedido
                        where p.IdPedido == id
                        select p).FirstOrDefault();
            pedi.Estado = "Recibido";

            var mande = _context.DetallesPedido.Where(x => x.IdPedido == id).ToList();


            foreach (DetallesPedido item in mande)
            {
                var pro = _context.Producto.Where(x => x.IdProducto == item.IdProducto).FirstOrDefault();


                pro.Existencia = pro.Existencia + item.UnidadesSolicitadas;
                pro.FechaCadu = item.FechaCaducidad;

                _context.Update(pro);
            }
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult detalles(int id) 
        {
            return RedirectToAction("Index","DetallesPedidos"); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2.Models;

namespace ProyectoFinal2020v2.Controllers
{
    public class FacturacionController : Controller
    {
        private readonly GymContext _context;
        public FacturacionController(GymContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var compras = _context.Compra.ToList();

            return View(compras);
        }
        public IActionResult Create()
        {
            var cero = _context.Compra.Max(c => c.IdCompra);
            if (cero == 0)
            {
                ViewData["IdCompra"] = 1;
            }
            else
            {
                ViewData["IdCompra"] = _context.Compra.Max(c => c.IdCompra) + 1;
            }

            TempData["Fecha"] = DateTime.Now.ToString("dd/MM/yyyy");
            List<Cliente> clientes = _context.Cliente.Where(c => c.Estado == "Activo").ToList();
            ViewData["Cliente"] = clientes;
            List<Empleado> empleados = _context.Empleado.Where(e => e.Estado == "Activo").ToList();
            ViewData["Empleado"] = empleados;
            List<Producto> productos = _context.Producto.Where(p => p.Existencia > 0).Include(p => p.IdCategoriaNavigation).ToList();
            ViewData["Producto"] = productos;
            return View();
        }

        public IActionResult Guardar(FacturacionViewModel factura)
        {
            if (ModelState.IsValid)
            {

                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        Compra comprar = new Compra//Agregar compra
                        {
                            //IdCompra = ((int)factura.Compra.IdCompra),
                            IdCliente = factura.Compra.IdCliente,
                            Fecha = factura.Compra.Fecha,
                            Importe = ((int)factura.Compra.Importe),
                            IdEmpleado = factura.Compra.IdEmpleado
                        };

                        _context.Add(comprar);
                        _context.SaveChanges();
                        foreach (DetalleCompra item in factura.DetalleCompra)
                        {
                            DetalleCompra detalle = new DetalleCompra//Agregar detalleCompra
                            {
                                IdCompra = ((int)factura.Compra.IdCompra),
                                IdProducto = item.IdProducto,
                                PrecioUnidad = item.PrecioUnidad,
                                Cantidad = item.Cantidad,
                                Descuento = 0
                            };
                            var producto = _context.Producto.Where(p => p.IdProducto == item.IdProducto);
                            foreach (var item2 in producto)//descuenta producto del stock
                            {
                                item2.Existencia = ((int)item2.Existencia - (int)item.Cantidad);
                                _context.Update(item2);
                            }

                            _context.Add(detalle);
                        }
                        _context.SaveChanges();

                        var monederoCliente = _context.Monedero.Where(m => m.IdCliente == ((int)factura.Compra.IdCliente));
                        foreach (var item3 in monederoCliente)//resta el monedero
                        {
                            item3.Saldo = ((double)item3.Saldo - ((double)factura.Compra.Importe));
                            _context.Update(item3);
                        }
                        _context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch
                    {

                        dbContextTransaction.Rollback();

                    }
                }

                Thread.Sleep(2000);
                return RedirectToAction("Index");
            }

            ViewData["Fecha"] = DateTime.Now.ToString("dd/MM/yyyy");
            List<Cliente> clientes = _context.Cliente.Where(c => c.Estado == "Activo").ToList();
            ViewData["Cliente"] = clientes;
            List<Empleado> empleados = _context.Empleado.Where(e => e.Estado == "Activo").ToList();
            ViewData["Empleado"] = empleados;
            List<Producto> productos = _context.Producto.Where(p => p.Existencia > 0).Include(p => p.IdCategoriaNavigation).ToList();
            ViewData["Producto"] = productos;
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var compra = _context.Compra.Where(c => c.IdCompra == id).FirstOrDefault();
            List<Producto> productos = _context.Producto.Where(p => p.Existencia > 0).Include(p => p.IdCategoriaNavigation).ToList();
            ViewData["Producto"] = productos;

            List<DetalleCompra> detallecompra = _context.DetalleCompra.Where(d => d.IdCompra == id).Include(d => d.IdProductoNavigation).ToList();
            ViewData["DetalleCompra"] = detallecompra;
            FacturacionViewModel facturacion = new FacturacionViewModel();
            facturacion.Compra = compra;
            //facturacion.DetalleCompra = detallecompra;
            return View(facturacion);
        }
        [HttpGet]
        public ActionResult ValidarExistencia(int idProducto, int cantidad, int idcliente, int total)
        {
            string codeError = null;
            Producto productoFind = _context.Producto.FirstOrDefault(p => p.IdProducto == idProducto);
            Monedero clienteSaldo = _context.Monedero
                          .FirstOrDefault(cl => cl.IdCliente == idcliente);
            if (productoFind.Existencia < cantidad)
            {
                codeError = "1";//Cantidad insuficiente
            }
            else if (cantidad <= 0)
            {
                codeError = "2";//cantidada no validad
            }
            else if (clienteSaldo.Saldo <= total || ((cantidad * productoFind.PrecioUnidad) > clienteSaldo.Saldo))
            {
                codeError = "3";
            }
            else
            {
                codeError = "0";//No hay errores
            }
            return Json(new
            {
                code = codeError,
                idProducto = productoFind.IdProducto,
                nombre = productoFind.Nombre,
                existencia = cantidad,
                precioUnidad = productoFind.PrecioUnidad,
                subTotal = cantidad * productoFind.PrecioUnidad
            });
        }

        public IActionResult Details(int id)
        {
            var clase = _context.Compra.Include(c => c.IdClienteNavigation).Include(c => c.IdEmpleadoNavigation).FirstOrDefault(c => c.IdCompra == id);
            List<DetalleCompra> detalles = _context.DetalleCompra.Include(d => d.IdProductoNavigation).Where(d => d.IdCompra == id).ToList();
            ViewData["Detalles"] = detalles;

            return View(clase);
        }
        public ActionResult EditarAjax(FacturacionViewModel facturacion)
        {
            if (ModelState.IsValid)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (DetalleCompra item in facturacion.DetalleCompra)
                        {
                            var existeCompra = _context.DetalleCompra
                                .Where(dc => (dc.IdCompra == facturacion.Compra.IdCompra && dc.IdProducto == item.IdProducto)).FirstOrDefault();
                            var producto = _context.Producto.Where(p => p.IdProducto == item.IdProducto).FirstOrDefault();
                            var monedero = _context.Monedero.Where(m => m.IdCliente == facturacion.Compra.IdCliente).FirstOrDefault();

                            var diferencia = ((int)existeCompra.Cantidad - (int)item.Cantidad);
                            facturacion.Compra.Importe -= (diferencia * (int)existeCompra.PrecioUnidad);

                            if (existeCompra != null && producto != null)
                            {
                                existeCompra.Cantidad -= (int)diferencia;
                                producto.Existencia -= (int)diferencia;
                                _context.Update(existeCompra);
                                _context.Update(producto);
                            }
                            else
                            {
                                DetalleCompra detalle = new DetalleCompra();
                                detalle.IdCompra = facturacion.Compra.IdCompra;
                                detalle.IdProducto = item.IdProducto;
                                detalle.PrecioUnidad = item.PrecioUnidad;
                                detalle.Cantidad = item.Cantidad;
                                detalle.Descuento = 0;
                                _context.Add(detalle);
                            }
                            monedero.Saldo += (int)diferencia * (int)existeCompra.PrecioUnidad;

                            var compraImporte = _context.Compra.Where(c => c.IdCompra == facturacion.Compra.IdCompra).FirstOrDefault();
                            compraImporte.Importe = facturacion.Compra.Importe;
                            _context.Update(compraImporte);
                            _context.Update(monedero);
                            _context.SaveChanges();
                            dbContextTransaction.Commit();
                        }
                        return Json(new { result = true });
                    }
                    catch
                    {
                        dbContextTransaction.Rollback();
                    }
                }

            }
            return Json(new { result = false });
        }
        public ActionResult AgregarAjax(FacturacionViewModel facturacion)
        {
            if (ModelState.IsValid)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (DetalleCompra item in facturacion.DetalleCompra)
                        {
                            var existeCompra = _context.DetalleCompra
                                .Where(dc => (dc.IdCompra == facturacion.Compra.IdCompra && dc.IdProducto == item.IdProducto)).FirstOrDefault();
                            var producto = _context.Producto.Where(p => p.IdProducto == item.IdProducto).FirstOrDefault();
                            var monedero = _context.Monedero.Where(m => m.IdCliente == facturacion.Compra.IdCliente).FirstOrDefault();

                            var diferencia = ((int)existeCompra.Cantidad + (int)item.Cantidad);
                            facturacion.Compra.Importe += ((int)item.Cantidad * (int)item.PrecioUnidad);

                            if (existeCompra != null && producto != null)
                            {
                                existeCompra.Cantidad = (int)diferencia;
                                producto.Existencia -= (int)item.Cantidad;
                                _context.Update(existeCompra);
                                _context.Update(producto);
                            }
                            else
                            {
                                DetalleCompra detalle = new DetalleCompra();
                                detalle.IdCompra = facturacion.Compra.IdCompra;
                                detalle.IdProducto = item.IdProducto;
                                detalle.PrecioUnidad = item.PrecioUnidad;
                                detalle.Cantidad = item.Cantidad;
                                detalle.Descuento = 0;
                                _context.Add(detalle);
                            }
                            monedero.Saldo -= ((int)item.Cantidad * (int)item.PrecioUnidad);

                            var compraImporte = _context.Compra.Where(c => c.IdCompra == facturacion.Compra.IdCompra).FirstOrDefault();
                            compraImporte.Importe = facturacion.Compra.Importe;
                            _context.Update(compraImporte);
                            _context.Update(monedero);
                            _context.SaveChanges();
                            dbContextTransaction.Commit();
                        }
                        return Json(new { result = true });
                    }
                    catch
                    {
                        dbContextTransaction.Rollback();
                    }
                }

            }
            return Json(new { result = false });
        }

        [HttpGet]
        public ActionResult ValidarEliminar(int idProducto, int cantidad, int idcompra)
        {
            string codeError = null;
            var detalleExis = _context.DetalleCompra.Where(dc => dc.IdCompra == idcompra && dc.IdProducto == idProducto).FirstOrDefault();
            Producto productoFind = _context.Producto.FirstOrDefault(p => p.IdProducto == idProducto);

            if (cantidad <= detalleExis.Cantidad && cantidad > 0)
            {
                codeError = "0";//No hay errores
            }
            else if (cantidad <= 0)
            {
                codeError = "2";//cantidada no validad
            }
            else
            {
                codeError = "1";//Cantidad insuficiente
            }
            return Json(new
            {
                code = codeError
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarAjax(FacturacionViewModel facturacion)
        {
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (DetalleCompra item in facturacion.DetalleCompra)
                    {
                        var DetalleproductoEliminar = _context.DetalleCompra
                        .Where(dc => dc.IdCompra == facturacion.Compra.IdCompra && dc.IdProducto == item.IdProducto)
                        .FirstOrDefault();
                        var producto = _context.Producto
                            .Where(p => p.IdProducto == DetalleproductoEliminar.IdProducto)
                            .FirstOrDefault();
                        var monedero = _context.Monedero
                            .Where(m => m.IdCliente == facturacion.Compra.IdCliente)
                            .FirstOrDefault();
                        producto.Existencia += (int)DetalleproductoEliminar.Cantidad;
                        monedero.Saldo += (int)DetalleproductoEliminar.Cantidad * (int)DetalleproductoEliminar.PrecioUnidad;
                        _context.Update(producto);
                        _context.Update(monedero);
                        _context.Remove(DetalleproductoEliminar);
                    }
                    _context.SaveChanges();
                    dbContextTransaction.Commit();

                }
                catch
                {
                    dbContextTransaction.Rollback();
                }
                return Json(new { result = true, });
            }


        }
    }

    //public IActionResult Create()
    //{ }


}

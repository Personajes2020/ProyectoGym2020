using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal2020v2.Models;

namespace ProyectoFinal2020v2.Controllers
{
    public class RecargasMVController : Controller
    {
        public readonly GymContext _context;
        public RecargasMVController(GymContext context)
        {
            _context = context;
        }
        // GET: RecargasMVController
        public ActionResult Index()
        {
            List<Monedero> monedero = _context.Monedero
                .Include(m => m.IdClienteNavigation)
                .ToList();
            TempData["Cliente"] = monedero;
            List<RecargaMonederoV> recargas = _context.RecargaMonederoV.ToList();
            ViewData["ListaRecarga"] = recargas;
            return View();
        }

        // GET: RecargasMVController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecargasMVController/Create
        public ActionResult Create()
        {
            return RedirectToAction("Index");
        }

        // POST: RecargasMVController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("IdRecargaMV, IdMonedero, Monto")] RecargaMonederoV recargaMonederoV)
        {
            recargaMonederoV.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var sumarmonto = _context.Monedero.Where(m => m.IdMonedero == recargaMonederoV.IdMonedero);
                        if (sumarmonto != null)
                        {
                            foreach (var item in sumarmonto)
                            {
                                item.Saldo = ((float)item.Saldo + recargaMonederoV.Monto);
                            }
                            _context.Add(recargaMonederoV);
                            dbContextTransaction.Commit();
                            await _context.SaveChangesAsync();
                        }


                    }
                    catch
                    {
                        dbContextTransaction.Rollback();
                    }

                }
                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index");
        }

        // GET: RecargasMVController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecargasMVController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecargasMVController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecargasMVController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax([Bind("IdRecargaMV, IdMonedero, Monto")] RecargaMonederoV recargaMonederoV)
        {//ESTE METODO LO QUE HACE ES RETORNAR UN RESULT PARA UTILIZARLO EN LA VISTA CREATE JUNTO LA SWEET ALERT
            recargaMonederoV.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
              
                return Json(new { result = true }); 
            }
            return Json(new { result = false }); 
        }
    }
}

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
        public async Task<IActionResult> IndexClase1(int num)
        {
            //ClaseGym claseGym = new ClaseGym();
            var gymContext = _context.ClaseGym
                .Include(c => c.IdActividadNavigation)
                .Include(c => c.IdEmpleadoNavigation)
                .Include(c => c.IdSalaNavigation);
            return View("SelectCreateClase", await gymContext.ToListAsync());

        }
        public async Task<IActionResult> IndexClase2(int num)
        {
              var gymContext = _context.ClaseGym
                  .Include(c => c.IdActividadNavigation)
                  .Include(c => c.IdEmpleadoNavigation)
                  .Include(c => c.IdSalaNavigation);
               return View("SelectEditClase", await gymContext.ToListAsync());
        }

            // GET: MatriculasClaseGym/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //MatriculaGymViewModel matriculaClaseGym =(MatriculaGymViewModel)(from m in _context.MatriculaClaseGym
            //                        join cl in _context.ClaseGym on m.IdClaseGym equals cl.IdClaseGym
            //                        join a in _context.Actividad on cl.IdActividad equals a.IdActividad
            //                        join cli in _context.Cliente on m.IdCliente equals cli.IdCliente
            //                        where(m.IdMatriculaGym==id)
            //                        select new MatriculaGymViewModel
            //                        {
            //                            IdMatriculaGym= m.IdMatriculaGym,
            //                            IdClase = a.IdActividad,
            //                            Clase= a.Nombre,
            //                            IdCliente =cli.Identificacion,
            //                            Cliente= cli.Nombre ,
            //                            Fecha = m.Fecha
            //                        });
            //var seleccion = matriculaClaseGym.Equals(matriculaClaseGym.IdMatriculaGym==id);

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
            if (TempData.ContainsKey("IdClase1"))
            {
                TempData["IdClaseGym"] = (int)TempData["IdClase1"];
            }
            ViewData["IdCliente"] = _context.Cliente.Select(e => new SelectListItem
            {
                Text = e.Nombre + " " + e.Apellido1 + " " + e.Apellido2,
                Value = e.IdCliente.ToString()
            });
            return View();
        }

        // POST: MatriculasClaseGym/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMatriculaGym,IdCliente,IdClaseGym")] MatriculaClaseGym matriculaClaseGym)
        {
            matriculaClaseGym.Fecha= DateTime.Now;
            
            if (ModelState.IsValid)
            {
               
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    var validarCliente = _context.MatriculaClaseGym.Any(m => m.IdCliente.Equals(matriculaClaseGym.IdCliente));
                    if (validarCliente)
                    {
                        ModelState.AddModelError("IdCliente", "El cliente que quiere ingresar ya esta matriculado");
                        Thread.Sleep(3500);
                        return View("create");


                    }
                    try
                    {
                        
                        _context.Add(matriculaClaseGym);
                        //await _context.SaveChangesAsync();

                        //var restarCupo = _context.ClaseGym.Where(cl => cl.IdClaseGym == matriculaClaseGym.IdClaseGym).FirstOrDefault();
                        var restarCupo = from clas in _context.ClaseGym
                                             //join m in _context.MatriculaClaseGym on clas.IdClaseGym equals m.IdClaseGym
                                         where (clas.IdClaseGym == matriculaClaseGym.IdClaseGym)
                                         select clas;
                        foreach (var item in restarCupo)
                        {
                            //if (item.Cupo==0) {
                            //ModelState.AddModelError()
                            //}
                            item.Cupo = ((int)(item.Cupo - 1));
                            _context.ClaseGym.Update(item);
                        }
                        await _context.SaveChangesAsync();
                        dbContextTransaction.Commit();//guarda los cambios hasta aqui
                    }
                    catch
                    {
                        dbContextTransaction.Rollback();//elimina todo si para un error(devuelve)
                    }

                }
                Thread.Sleep(1000);
                 return RedirectToAction(nameof(Index));
            }
            
            //ViewData["Fecha"] = DateTime.Now;
            //if (TempData.ContainsKey("IdClase1"))
            //{
            //    ViewData["IdClaseGym"] = (int)TempData["IdClase1"];
            //}
            ViewData["IdClaseGym"] = new SelectList(_context.ClaseGym, "IdClaseGym", "IdClaseGym", matriculaClaseGym.IdClaseGym);
            ViewData["IdCliente"] = _context.Cliente
                .Where(e => e.IdCliente == matriculaClaseGym.IdCliente)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1 + " " + e.Apellido2,
                    Value = e.IdCliente.ToString()
                });
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

            if (TempData["IdClase2"] == null)
            {
                ViewData["IdClaseGym"] = matriculaClaseGym.IdClaseGym;
            }
            else
            {
                ViewData["IdClaseGym"] = (int)TempData["IdClase2"];
            }
            TempData["IdDeMatricula"] = id;
            ViewData["IdCliente"] = _context.Cliente
                .Where(e => e.IdCliente == matriculaClaseGym.IdCliente)
                .Select(e => new SelectListItem
                {
                    Text = e.Nombre + " " + e.Apellido1 + " " + e.Apellido2,
                    Value = e.IdCliente.ToString()
                });
            return View(matriculaClaseGym);
        }

        // POST: MatriculasClaseGym/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMatriculaGym,IdCliente,IdClaseGym")] MatriculaClaseGym matriculaClaseGym)
        {
            if (id != matriculaClaseGym.IdMatriculaGym)
            {
                return NotFound();
            }
            matriculaClaseGym.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try 
                    {
                        var cambiarCupo = _context.MatriculaClaseGym
                        .Where(m => m.IdMatriculaGym == matriculaClaseGym.IdMatriculaGym && m.IdClaseGym != matriculaClaseGym.IdClaseGym)
                        .Select(m => m);
                        if (cambiarCupo != null)
                        {//valida si Coincide el IdMatri y si Idclase!=, que el de la BD
                            var clasenew = _context.ClaseGym
                                .Where(cl => cl.IdClaseGym == matriculaClaseGym.IdClaseGym);//trae la clase la cual - cupo
                            var clasbefore = _context.MatriculaClaseGym
                                .Where(m => m.IdMatriculaGym == matriculaClaseGym.IdMatriculaGym)
                                .Select(m => m.IdClaseGym)
                                .FirstOrDefault();// trae la clase pasada para + cupo
                            var clase2 = _context.ClaseGym.Where(cl => cl.IdClaseGym == clasbefore);
                            foreach (var item1 in clasenew)
                            {
                                item1.Cupo = ((int)(item1.Cupo - 1));
                                _context.Update(item1);
                            }
                            foreach (var item2 in clase2)
                            {
                                item2.Cupo = ((int)(item2.Cupo + 1));
                                _context.Update(item2);
                            }
                            
                            _context.Update(matriculaClaseGym);
                            dbContextTransaction.Commit();
                            await _context.SaveChangesAsync();
                        }
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        dbContextTransaction.Rollback();
                        if (!MatriculaClaseGymExists(matriculaClaseGym.IdMatriculaGym))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                Thread.Sleep(1000);
                return RedirectToAction(nameof(Index));
            }
            if (TempData.ContainsKey("IdClase2"))
            {
                ViewData["IdClaseGym"] = (int)TempData["IdClase2"];
            }
   
            ViewData["IdCliente"] = _context.Cliente
                 .Where(e => e.IdCliente == matriculaClaseGym.IdCliente)
                 .Select(e => new SelectListItem
                 {
                     Text = e.Nombre + " " + e.Apellido1 + " " + e.Apellido2,
                     Value = e.IdCliente.ToString()
                 });
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
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    using (var dbContextTransaction = _context.Database.BeginTransaction()) {
        //        try 
        //        {
        //            var matriculaClaseGym = /*await*/ _context.MatriculaClaseGym.Find/*Async*/(id);
        //            var desconCupo = _context.ClaseGym.Where(cl => cl.IdClaseGym == matriculaClaseGym.IdClaseGym);
        //            foreach (var item in desconCupo)
        //            {
        //                item.Cupo = ((int)(item.Cupo + 1));
        //                _context.Update(item); 
        //                dbContextTransaction.Commit();
        //            }
        //            _context.MatriculaClaseGym.Remove(matriculaClaseGym);
                   
        //            await _context.SaveChangesAsync();
                   
        //        } 
        //        catch 
        //        {
        //            dbContextTransaction.Rollback();
        //        }
                
        //    }
            
        //    Thread.Sleep(2000);
        //    return RedirectToAction(nameof(Index));
        //}

        private bool MatriculaClaseGymExists(int id)
        {
            return _context.MatriculaClaseGym.Any(e => e.IdMatriculaGym == id);
        }
        public IActionResult SelectA(int id)
        {
            TempData["IdClase1"] = id;
            return RedirectToAction("Create");
        }
        public IActionResult SelectB(int id)
        {
           //TempData["IdDeMatricula"] = id;
            TempData["IdClase2"] = id;
            int ids = (int)TempData["IdDeMatricula"];
            return RedirectToAction("Edit", new { id = ids});
        }
        //Validar para usar SweetAlert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateVali(MatriculaClaseGym matriculaClaseGym)
        {
            matriculaClaseGym.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var validarCliente = _context.MatriculaClaseGym.Any(m => m.IdCliente.Equals(matriculaClaseGym.IdCliente));
                if (validarCliente)
                {
                    //ModelState.AddModelError("IdCliente", "El cliente que quiere ingresar ya esta matriculado");
                    return Json(new { result = false });
                }
                return Json(new { result = true }); 
            }
            return Json(new { result = false }); 
        }
        public ActionResult EditVali(MatriculaClaseGym matriculaClaseGym)
        {
            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                return Json(new { result = true });
            }
            return Json(new { result = false });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteVali(MatriculaClaseGym matriculaClaseGym)
        {
            //MatriculaClaseGym MatriculaFind = _context.MatriculaClaseGym.Find(matriculaClaseGym.IdMatriculaGym);
            //_context.MatriculaClaseGym.Remove(MatriculaFind);
            //_context.SaveChanges();
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    MatriculaClaseGym matriculaFind = /*await*/ _context.MatriculaClaseGym.Find/*Async*/(matriculaClaseGym.IdMatriculaGym);
                    var desconCupo = _context.ClaseGym.Where(cl => cl.IdClaseGym == matriculaFind.IdClaseGym);
                    foreach (var item in desconCupo)
                    {
                        item.Cupo = ((int)(item.Cupo + 1));
                        _context.Update(item);
                        
                    }
                    _context.MatriculaClaseGym.Remove(matriculaFind);
                    dbContextTransaction.Commit();
                    _context.SaveChanges();

                }
                catch
                {
                    dbContextTransaction.Rollback();
                    //return Json(new { result = false });
                }

            }
            return Json(new { result = true });
        }
    }
}

﻿using System;
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
    public class ActividadesController : Controller
    {
        private readonly GymContext _context;

        public ActividadesController(GymContext context)
        {
            _context = context;
        }

        // GET: Actividads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actividad.ToListAsync());
        }

        // GET: Actividads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad
                .FirstOrDefaultAsync(m => m.IdActividad == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // GET: Actividads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actividads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdActividad,Nombre,Descripcion,Duracion,Estado")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividad);
                await _context.SaveChangesAsync();
                Thread.Sleep(1000); //Espera 1 segundos y redirecciona al index Actividades porque sino no muestra bien la SweetAlert
                return RedirectToAction(nameof(Index));
            }
            return View(actividad);
        }

        // GET: Actividads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }
            return View(actividad);
        }

        // POST: Actividads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdActividad,Nombre,Descripcion,Duracion,Estado")] Actividad actividad)
        {
            if (id != actividad.IdActividad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadExists(actividad.IdActividad))
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
            return View(actividad);
        }

        // GET: Actividads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividad
                .FirstOrDefaultAsync(m => m.IdActividad == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // POST: Actividads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actividad = await _context.Actividad.FindAsync(id);
            _context.Actividad.Remove(actividad);
            await _context.SaveChangesAsync();
            Thread.Sleep(1000);
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividad.Any(e => e.IdActividad == id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConAjax(Actividad actividad)
        {
            //string mensaje = "Error al eliminar actividad";
            Actividad actividadFind = _context.Actividad.Find(actividad.IdActividad);
            _context.Actividad.Remove(actividadFind);
            _context.SaveChanges();
            //mensaje = "Actividad elminada!";
            return Json(new { result = true,  });
        }
       
       

        // POST: Actividads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConAjax([Bind("IdActividad,Nombre,Descripcion,Duracion,Estado")] Actividad actividad)
        {//ESTE METODO LO QUE HACE ES RETORNAR UN RESULT PARA UTILIZARLO EN LA VISTA CREATE JUNTO LA SWEET ALERT
            if (ModelState.IsValid)
            {
                //_context.Add(actividad);
                //await _context.SaveChangesAsync();
                return Json(new { result = true }); //Si guarda result true
            }
            return Json(new { result = false }); //Si no guarda result = false
        }
        public ActionResult EditConAjax(Actividad actividad)
        {
            //string mensaje = "Error al editar el registro";
            if (ModelState.IsValid)
            {
               // _context.Entry(actividad).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new { result = true });
                //mensaje = "Registro editado";
            }
            return Json(new { result = false });
        }
    }
}

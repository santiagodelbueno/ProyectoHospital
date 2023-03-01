using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoHospital.Context;
using ProyectoHospital.Models;

namespace ProyectoHospital
{
    public class TurnoMedicoController : Controller
    {
        private readonly HospitalDatabaseContext _context;

        public TurnoMedicoController(HospitalDatabaseContext context)
        {
            _context = context;
        }

        // GET: TurnoMedico
        public async Task<IActionResult> Index()
        {
            var hospitalDatabaseContext = _context.TurnoMedico.Include(t => t.Medico).ThenInclude(m => m.Usuario).Include(t => t.Turno);
            return View(await hospitalDatabaseContext.ToListAsync());
        }

        // GET: TurnoMedico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnoMedico = await _context.TurnoMedico
                .Include(t => t.Medico)
                .Include(t => t.Turno)
                .FirstOrDefaultAsync(m => m.MedicoId == id);
            if (turnoMedico == null)
            {
                return NotFound();
            }

            return View(turnoMedico);
        }

        // GET: TurnoMedico/Create
        public IActionResult Create()
        {
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Nombre");
            ViewData["TurnoId"] = new SelectList(_context.Turno, "Id", "Fecha");
            return View();
        }

        // POST: TurnoMedico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,MedicoId,TurnoId")] TurnoMedico turnoMedico)
        {
            if (ModelState.IsValid)
            {
                if (_context.TurnoMedico.Any(tm => tm.MedicoId == turnoMedico.MedicoId && tm.TurnoId == turnoMedico.TurnoId))
                {
                    ModelState.AddModelError(string.Empty, "Ya existe un turno para este médico en la fecha seleccionada.");
                    ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Nombre", turnoMedico.MedicoId);
                    ViewData["TurnoId"] = new SelectList(_context.Turno, "Id", "Fecha", turnoMedico.TurnoId);
                    return View(turnoMedico);
                }

                _context.Add(turnoMedico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Nombre", turnoMedico.MedicoId);
            ViewData["TurnoId"] = new SelectList(_context.Turno, "Id", "Fecha", turnoMedico.TurnoId);
            return View(turnoMedico);
        }

        // GET: TurnoMedico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnoMedico = await _context.TurnoMedico.FindAsync(id);
            if (turnoMedico == null)
            {
                return NotFound();
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Nombre", turnoMedico.MedicoId);
            ViewData["TurnoId"] = new SelectList(_context.Turno, "Id", "Fecha", turnoMedico.TurnoId);
            return View(turnoMedico);
        }

        // POST: TurnoMedico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,MedicoId,TurnoId")] TurnoMedico turnoMedico)
        {
            if (id != turnoMedico.MedicoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turnoMedico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurnoMedicoExists(turnoMedico.MedicoId))
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
            ViewData["MedicoId"] = new SelectList(_context.Medico, "Id", "Nombre", turnoMedico.MedicoId);
            ViewData["TurnoId"] = new SelectList(_context.Turno, "Id", "Fecha", turnoMedico.TurnoId);
            return View(turnoMedico);
        }

        // GET: TurnoMedico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnoMedico = await _context.TurnoMedico
                .Include(t => t.Medico)
                .Include(t => t.Turno)
                .FirstOrDefaultAsync(m => m.MedicoId == id);
            if (turnoMedico == null)
            {
                return NotFound();
            }

            return View(turnoMedico);
        }

        // POST: TurnoMedico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turnoMedico = await _context.TurnoMedico.FindAsync(id);
            _context.TurnoMedico.Remove(turnoMedico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurnoMedicoExists(int id)
        {
            return _context.TurnoMedico.Any(e => e.MedicoId == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppDay10.Data;
using WebAppDay10.Models;

namespace WebAppDay10.Controllers
{

    [Authorize]
    public class MedicalHistoryController : Controller
    {
       
        private readonly MyDbContext _context;

        public MedicalHistoryController(MyDbContext context)
        {
            _context = context;
        }

        // GET: MedicalHistory
        public async Task<IActionResult> Index()
        {
              return _context.PatientHistory != null ? 
                          View(await _context.PatientHistory.ToListAsync()) :
                          Problem("Entity set 'MyDbContext.PatientHistory'  is null.");
        }

        // GET: MedicalHistory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PatientHistory == null)
            {
                return NotFound();
            }

            var patientHistory = await _context.PatientHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientHistory == null)
            {
                return NotFound();
            }

            return View(patientHistory);
        }

        // GET: MedicalHistory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicalHistory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,visitDate,doctorName,symptoms,medicine,remark")] PatientHistory patientHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patientHistory);
        }

        // GET: MedicalHistory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PatientHistory == null)
            {
                return NotFound();
            }

            var patientHistory = await _context.PatientHistory.FindAsync(id);
            if (patientHistory == null)
            {
                return NotFound();
            }
            return View(patientHistory);
        }

        // POST: MedicalHistory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,visitDate,doctorName,symptoms,medicine,remark")] PatientHistory patientHistory)
        {
            if (id != patientHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientHistoryExists(patientHistory.Id))
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
            return View(patientHistory);
        }

        // GET: MedicalHistory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PatientHistory == null)
            {
                return NotFound();
            }

            var patientHistory = await _context.PatientHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientHistory == null)
            {
                return NotFound();
            }

            return View(patientHistory);
        }

        // POST: MedicalHistory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PatientHistory == null)
            {
                return Problem("Entity set 'MyDbContext.PatientHistory'  is null.");
            }
            var patientHistory = await _context.PatientHistory.FindAsync(id);
            if (patientHistory != null)
            {
                _context.PatientHistory.Remove(patientHistory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientHistoryExists(int id)
        {
          return (_context.PatientHistory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

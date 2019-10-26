using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnePiece.Domain;
using OnePieceWeb.Data;

namespace WebApplication3.Controllers
{
    public class PiratesController : Controller
    {
        private readonly OnePieceContext _context;

        public PiratesController(OnePieceContext context)
        {
            _context = context;
        }

        // GET: Pirates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pirates.ToListAsync());
        }

        // GET: Pirates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pirate = await _context.Pirates
                .FirstOrDefaultAsync(m => m.PirateId == id);
            if (pirate == null)
            {
                return NotFound();
            }

            return View(pirate);
        }

        // GET: Pirates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pirates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PirateId,Name")] Pirate pirate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pirate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pirate);
        }

        // GET: Pirates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pirate = await _context.Pirates.FindAsync(id);
            if (pirate == null)
            {
                return NotFound();
            }
            return View(pirate);
        }

        // POST: Pirates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PirateId,Name")] Pirate pirate)
        {
            if (id != pirate.PirateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pirate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PirateExists(pirate.PirateId))
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
            return View(pirate);
        }

        // GET: Pirates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pirate = await _context.Pirates
                .FirstOrDefaultAsync(m => m.PirateId == id);
            if (pirate == null)
            {
                return NotFound();
            }

            return View(pirate);
        }

        // POST: Pirates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pirate = await _context.Pirates.FindAsync(id);
            _context.Pirates.Remove(pirate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PirateExists(int id)
        {
            return _context.Pirates.Any(e => e.PirateId == id);
        }
    }
}

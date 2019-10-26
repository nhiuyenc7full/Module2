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
    public class DevilFruitsController : Controller
    {
        private readonly OnePieceContext _context;

        public DevilFruitsController(OnePieceContext context)
        {
            _context = context;
        }

        // GET: DevilFruits
        public async Task<IActionResult> Index()
        {
            return View(await _context.DevilFruits.ToListAsync());
        }

        // GET: DevilFruits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devilFruit = await _context.DevilFruits
                .FirstOrDefaultAsync(m => m.DevilFruitId == id);
            if (devilFruit == null)
            {
                return NotFound();
            }

            return View(devilFruit);
        }

        // GET: DevilFruits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DevilFruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DevilFruitId,Name")] DevilFruit devilFruit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devilFruit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devilFruit);
        }

        // GET: DevilFruits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devilFruit = await _context.DevilFruits.FindAsync(id);
            if (devilFruit == null)
            {
                return NotFound();
            }
            return View(devilFruit);
        }

        // POST: DevilFruits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DevilFruitId,Name")] DevilFruit devilFruit)
        {
            if (id != devilFruit.DevilFruitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devilFruit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevilFruitExists(devilFruit.DevilFruitId))
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
            return View(devilFruit);
        }

        // GET: DevilFruits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devilFruit = await _context.DevilFruits
                .FirstOrDefaultAsync(m => m.DevilFruitId == id);
            if (devilFruit == null)
            {
                return NotFound();
            }

            return View(devilFruit);
        }

        // POST: DevilFruits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devilFruit = await _context.DevilFruits.FindAsync(id);
            _context.DevilFruits.Remove(devilFruit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevilFruitExists(int id)
        {
            return _context.DevilFruits.Any(e => e.DevilFruitId == id);
        }
    }
}

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
    public class CharacterPositionsController : Controller
    {
        private readonly OnePieceContext _context;

        public CharacterPositionsController(OnePieceContext context)
        {
            _context = context;
        }

        // GET: CharacterPositions
        public async Task<IActionResult> Index()
        {
            var onePieceContext = _context.CharacterPositions.Include(c => c.Character).Include(c => c.Position);
            return View(await onePieceContext.ToListAsync());
        }

        // GET: CharacterPositions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterPosition = await _context.CharacterPositions
                .Include(c => c.Character)
                .Include(c => c.Position)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (characterPosition == null)
            {
                return NotFound();
            }

            return View(characterPosition);
        }

        // GET: CharacterPositions/Create
        public IActionResult Create()
        {
            ViewData["CharacterId"] = new SelectList(_context.Characters, "CharacterId", "CharacterId");
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionId");
            return View();
        }

        // POST: CharacterPositions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharacterId,PositionId")] CharacterPosition characterPosition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(characterPosition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CharacterId"] = new SelectList(_context.Characters, "CharacterId", "CharacterId", characterPosition.CharacterId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionId", characterPosition.PositionId);
            return View(characterPosition);
        }

        // GET: CharacterPositions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterPosition = await _context.CharacterPositions.FindAsync(id);
            if (characterPosition == null)
            {
                return NotFound();
            }
            ViewData["CharacterId"] = new SelectList(_context.Characters, "CharacterId", "CharacterId", characterPosition.CharacterId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionId", characterPosition.PositionId);
            return View(characterPosition);
        }

        // POST: CharacterPositions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharacterId,PositionId")] CharacterPosition characterPosition)
        {
            if (id != characterPosition.CharacterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(characterPosition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterPositionExists(characterPosition.CharacterId))
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
            ViewData["CharacterId"] = new SelectList(_context.Characters, "CharacterId", "CharacterId", characterPosition.CharacterId);
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionId", characterPosition.PositionId);
            return View(characterPosition);
        }

        // GET: CharacterPositions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterPosition = await _context.CharacterPositions
                .Include(c => c.Character)
                .Include(c => c.Position)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (characterPosition == null)
            {
                return NotFound();
            }

            return View(characterPosition);
        }

        // POST: CharacterPositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var characterPosition = await _context.CharacterPositions.FindAsync(id);
            _context.CharacterPositions.Remove(characterPosition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterPositionExists(int id)
        {
            return _context.CharacterPositions.Any(e => e.CharacterId == id);
        }
    }
}

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
    public class CharactersController : Controller
    {
        private readonly OnePieceContext _context;

        public CharactersController(OnePieceContext context)
        {
            _context = context;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {
            var onePieceContext = _context.Characters.Include(c => c.DevilFruit).Include(c => c.Pirate);
            return View(await onePieceContext.ToListAsync());
        }

        // GET: Characters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.DevilFruit)
                .Include(c => c.Pirate)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // GET: Characters/Create
        public IActionResult Create()
        {
            ViewData["DevilFruitId"] = new SelectList(_context.DevilFruits, "DevilFruitId", "DevilFruitId");
            ViewData["PirateId"] = new SelectList(_context.Pirates, "PirateId", "PirateId");
            ViewBag.DevilFruits = _context.DevilFruits.ToList();
            ViewBag.Pirates = _context.Pirates.ToList();
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharacterId,Name,Price,Gender,PirateId,DevilFruitId")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DevilFruitId"] = new SelectList(_context.DevilFruits, "DevilFruitId", "DevilFruitId", character.DevilFruitId);
            ViewData["PirateId"] = new SelectList(_context.Pirates, "PirateId", "PirateId", character.PirateId);
            return View(character);
        }

        // GET: Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            ViewData["DevilFruitId"] = new SelectList(_context.DevilFruits, "DevilFruitId", "DevilFruitId", character.DevilFruitId);
            ViewData["PirateId"] = new SelectList(_context.Pirates, "PirateId", "PirateId", character.PirateId);
            ViewBag.DevilFruits = _context.DevilFruits.ToList();
            ViewBag.Pirates = _context.Pirates.ToList();
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharacterId,Name,Price,Gender,PirateId,DevilFruitId")] Character character)
        {
            if (id != character.CharacterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.CharacterId))
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
            ViewData["DevilFruitId"] = new SelectList(_context.DevilFruits, "DevilFruitId", "DevilFruitId", character.DevilFruitId);
            ViewData["PirateId"] = new SelectList(_context.Pirates, "PirateId", "PirateId", character.PirateId);
            return View(character);
        }

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.DevilFruit)
                .Include(c => c.Pirate)
                .FirstOrDefaultAsync(m => m.CharacterId == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.CharacterId == id);
        }
    }
}

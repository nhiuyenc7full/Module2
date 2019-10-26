using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoDeTracNghiemDemo.Models;

namespace BoDeTracNghiemDemo.Controllers
{
    public class DiemsController : Controller
    {
        private readonly AppDataContext _context;

        public DiemsController(AppDataContext context)
        {
            _context = context;
        }

        // GET: Diems
        public async Task<IActionResult> Index()
        {
            var appDataContext = _context.Diems.Include(d => d.Thi);
            return View(await appDataContext.ToListAsync());
        }

        // GET: Diems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diem = await _context.Diems
                .Include(d => d.Thi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diem == null)
            {
                return NotFound();
            }

            return View(diem);
        }

        // GET: Diems/Create
        public IActionResult Create()
        {
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten");
            return View();
        }

        // POST: Diems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,ThiId")] Diem diem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten", diem.ThiId);
            return View(diem);
        }

        // GET: Diems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diem = await _context.Diems.FindAsync(id);
            if (diem == null)
            {
                return NotFound();
            }
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten", diem.ThiId);
            return View(diem);
        }

        // POST: Diems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,ThiId")] Diem diem)
        {
            if (id != diem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiemExists(diem.Id))
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
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten", diem.ThiId);
            return View(diem);
        }

        // GET: Diems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diem = await _context.Diems
                .Include(d => d.Thi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diem == null)
            {
                return NotFound();
            }

            return View(diem);
        }

        // POST: Diems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diem = await _context.Diems.FindAsync(id);
            _context.Diems.Remove(diem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiemExists(int id)
        {
            return _context.Diems.Any(e => e.Id == id);
        }
    }
}

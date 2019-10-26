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
    public class CauHoiThisController : Controller
    {
        private readonly AppDataContext _context;

        public CauHoiThisController(AppDataContext context)
        {
            _context = context;
        }

        // GET: CauHoiThis
        public async Task<IActionResult> Index()
        {
            var appDataContext = _context.CauHoiThis.Include(c => c.CauHoi).Include(c => c.Thi);
            return View(await appDataContext.ToListAsync());
        }

        // GET: CauHoiThis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThis
                .Include(c => c.CauHoi)
                .Include(c => c.Thi)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }

            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Create
        public IActionResult Create()
        {
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten");
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten");
            return View();
        }

        // POST: CauHoiThis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CauHoiId,ThiId,Ten")] CauHoiThi cauHoiThi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauHoiThi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten");
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten");
            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThis.FindAsync(id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten", cauHoiThi.Ten);
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten", cauHoiThi.ThiId);
            return View(cauHoiThi);
        }

        // POST: CauHoiThis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CauHoiId,ThiId,Ten")] CauHoiThi cauHoiThi)
        {
            if (id != cauHoiThi.CauHoiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cauHoiThi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CauHoiThiExists(cauHoiThi.CauHoiId))
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
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Id", cauHoiThi.CauHoiId);
            ViewData["ThiId"] = new SelectList(_context.This, "Id", "Ten", cauHoiThi.ThiId);
            return View(cauHoiThi);
        }

        // GET: CauHoiThis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cauHoiThi = await _context.CauHoiThis
                .Include(c => c.CauHoi)
                .Include(c => c.Thi)
                .FirstOrDefaultAsync(m => m.CauHoiId == id);
            if (cauHoiThi == null)
            {
                return NotFound();
            }

            return View(cauHoiThi);
        }

        // POST: CauHoiThis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauHoiThi = await _context.CauHoiThis.FindAsync(id);
            _context.CauHoiThis.Remove(cauHoiThi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CauHoiThiExists(int id)
        {
            return _context.CauHoiThis.Any(e => e.CauHoiId == id);
        }
    }
}

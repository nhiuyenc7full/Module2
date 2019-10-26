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
    public class DapAnsController : Controller
    {
        private readonly AppDataContext _context;

        public DapAnsController(AppDataContext context)
        {
            _context = context;
        }

        // GET: DapAns
        public async Task<IActionResult> Index()
        {
            var appDataContext = _context.DapAns.Include(d => d.CauHoi);
            return View(await appDataContext.ToListAsync());
        }

        // GET: DapAns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns
                .Include(d => d.CauHoi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dapAn == null)
            {
                return NotFound();
            }

            return View(dapAn);
        }

        // GET: DapAns/Create
        public IActionResult Create()
        {
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten");
            return View();
        }

        // POST: DapAns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,CauHoiId")] DapAn dapAn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dapAn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Id", dapAn.CauHoiId);
            return View(dapAn);
        }

        // GET: DapAns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns.FindAsync(id);
            if (dapAn == null)
            {
                return NotFound();
            }
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten", dapAn.CauHoiId);
            return View(dapAn);
        }

        // POST: DapAns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,CauHoiId")] DapAn dapAn)
        {
            if (id != dapAn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dapAn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DapAnExists(dapAn.Id))
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
            ViewData["CauHoiId"] = new SelectList(_context.CauHoi, "Id", "Ten", dapAn.CauHoiId);
            return View(dapAn);
        }

        // GET: DapAns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dapAn = await _context.DapAns
                .Include(d => d.CauHoi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dapAn == null)
            {
                return NotFound();
            }

            return View(dapAn);
        }

        // POST: DapAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dapAn = await _context.DapAns.FindAsync(id);
            _context.DapAns.Remove(dapAn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DapAnExists(int id)
        {
            return _context.DapAns.Any(e => e.Id == id);
        }
    }
}

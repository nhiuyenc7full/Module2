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
    public class ThisController : Controller
    {
        private readonly AppDataContext _context;

        public ThisController(AppDataContext context)
        {
            _context = context;
        }

        // GET: This
        public async Task<IActionResult> Index()
        {
            var appDataContext = _context.This.Include(t => t.NguoiDung);
            return View(await appDataContext.ToListAsync());
        }
        public async Task<IActionResult> List()
        {
            var listCauHoi = _context.CauHoi.Include(c => c.DapAn).ToList();
            var cauHois = new List<CauHoi>();
            //var dapAns = new List<DapAn>();
            var i = 0;
            var rd = new Random();
            while (i < 4)
            {
                int a = rd.Next(0, listCauHoi.Count);
                cauHois.Add(listCauHoi.ToArray()[a]);
                //dapAns.Add(listCauHoi.ToArray()[a].DapAn);
                listCauHoi.RemoveAt(a);
                
                i++;
            }
            return View(cauHois);
        }
        [HttpPost]
        public async Task<IActionResult> List(List<DapAn> dapAns)
        {

            return View(dapAns);
        }


        // GET: This/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.This
                .Include(t => t.NguoiDung)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thi == null)
            {
                return NotFound();
            }

            return View(thi);
        }

        // GET: This/Create
        public IActionResult Create()
        {
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "Id", "DiaChi");
            return View();
        }

        // POST: This/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,CauHoiThiId,NguoiDungId")] Thi thi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "Id", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // GET: This/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.This.FindAsync(id);
            if (thi == null)
            {
                return NotFound();
            }
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "Id", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // POST: This/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,CauHoiThiId,NguoiDungId")] Thi thi)
        {
            if (id != thi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThiExists(thi.Id))
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
            ViewData["NguoiDungId"] = new SelectList(_context.NguoiDungs, "Id", "DiaChi", thi.NguoiDungId);
            return View(thi);
        }

        // GET: This/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thi = await _context.This
                .Include(t => t.NguoiDung)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thi == null)
            {
                return NotFound();
            }

            return View(thi);
        }

        // POST: This/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thi = await _context.This.FindAsync(id);
            _context.This.Remove(thi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThiExists(int id)
        {
            return _context.This.Any(e => e.Id == id);
        }
    }
}

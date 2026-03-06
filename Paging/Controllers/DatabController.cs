using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Paging.Data;
using Paging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paging.Controllers
{
    public class DatabController : Controller
    {
        private readonly DataDb _context;

        public DatabController(DataDb context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 0)
        {
            var students = _context.Datab
                .FromSqlRaw(
                    "EXEC Paging @counter",
                    new SqlParameter("@counter", page)
                )
                .ToList();

            ViewBag.Page = page;

            return View(students);
        }

        // GET: Databs
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Datab.ToListAsync());
        //}

        // GET: Databs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datab = await _context.Datab
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datab == null)
            {
                return NotFound();
            }

            return View(datab);
        }

        // GET: Databs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Databs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Datab datab)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datab);
        }

        // GET: Databs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datab = await _context.Datab.FindAsync(id);
            if (datab == null)
            {
                return NotFound();
            }
            return View(datab);
        }

        // POST: Databs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Datab datab)
        {
            if (id != datab.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datab);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatabExists(datab.Id))
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
            return View(datab);
        }

        // GET: Databs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datab = await _context.Datab
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datab == null)
            {
                return NotFound();
            }

            return View(datab);
        }

        // POST: Databs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datab = await _context.Datab.FindAsync(id);
            if (datab != null)
            {
                _context.Datab.Remove(datab);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatabExists(int id)
        {
            return _context.Datab.Any(e => e.Id == id);
        }
    }
}

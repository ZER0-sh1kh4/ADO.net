using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IDCard.Data;
using IDCard.Models;

namespace IDCard.Controllers
{
    public class CollegeApplicationsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CollegeApplicationsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // ─────────────────────────────────────────
        // INDEX
        // ─────────────────────────────────────────

        public async Task<IActionResult> Index()
        {
            var applications = await _db.CollegeApplications.ToListAsync();
            return View(applications);
        }

        // ─────────────────────────────────────────
        // CREATE
        // ─────────────────────────────────────────

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CollegeApplication model)
        {
            if (ModelState.IsValid)
            {
                model.AppliedOn = DateTime.Now;
                _db.CollegeApplications.Add(model);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // ─────────────────────────────────────────
        // EDIT
        // ─────────────────────────────────────────

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return BadRequest();

            var application = await _db.CollegeApplications.FindAsync(id);

            if (application == null)
                return NotFound();

            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CollegeApplication model)
        {
            if (id != model.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Entry(model).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_db.CollegeApplications.Any(e => e.Id == id))
                        return NotFound();
                    else
                        throw;
                }
            }
            return View(model);
        }

        // ─────────────────────────────────────────
        // DETAILS
        // ─────────────────────────────────────────

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return BadRequest();

            var application = await _db.CollegeApplications
                .FirstOrDefaultAsync(m => m.Id == id);

            if (application == null)
                return NotFound();

            return View(application);
        }

        // ─────────────────────────────────────────
        // DELETE
        // ─────────────────────────────────────────

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();

            var application = await _db.CollegeApplications
                .FirstOrDefaultAsync(m => m.Id == id);

            if (application == null)
                return NotFound();

            return View(application);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _db.CollegeApplications.FindAsync(id);

            if (application != null)
            {
                _db.CollegeApplications.Remove(application);
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        // ─────────────────────────────────────────
        // ID CARD
        // ─────────────────────────────────────────

        // GET: CollegeApplications/IdCard/5
        public async Task<IActionResult> IdCard(int? id)
        {
            if (id == null)
                return BadRequest();

            var application = await _db.CollegeApplications
                .FirstOrDefaultAsync(m => m.Id == id);

            if (application == null)
                return NotFound();

            return View(application);
        }
    }
}
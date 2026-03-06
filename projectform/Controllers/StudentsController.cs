using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectform.Data;
using projectform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectform.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentManagement _context;

        public StudentsController(StudentManagement context)
        {
            _context = context;
        }

        public IActionResult Create(string name, float age, string city)
        {
            var student = new Student
            {
                Name = name,
                Age = age,
                City = city
            };

            _context.Students.Add(student);
            _context.SaveChanges();


            return Content("Student Created Successfully");
        }
        // GET: Students
        public IActionResult GetAll()
        {
            var students = _context.Students.ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var s in students)
            {
                sb.Append($"{s.Id} - {s.Name} - {s.Age} - {s.City} <br>");
            }

            return Content(sb.ToString(), "text/html");
        }


        //Students/Details/1
        public IActionResult Details(int id)
        {
            var s = _context.Students.Find(id);

            if (s == null)
                return Content("Student not found");

            return Content($"{s.Id} - {s.Name} - {s.Age} - {s.City}");
        }
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return Content("Student not found");

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Content("Student Deleted Successfully");
        }
        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            return View(student);
        }
        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Students.Any(e => e.Id == student.Id))
                        return NotFound();
                    else
                        throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
        // GET: Students/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var student = await _context.Students
        //        .FirstOrDefaultAsync(m => m.Id == id);

        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(student);
        //}

    }
}

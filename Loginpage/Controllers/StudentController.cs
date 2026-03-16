using Loginpage.Services;
using Loginpage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loginpage.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // Shows semester marks for a student
        [HttpGet("marks/{id}")]
        public IActionResult Marks(int id)
        {
            var marks = _service.GetMarks(id);
            return View(marks);
        }

        // Generates the ID card view for a student
        [HttpGet("idcard/{id}")]
        public IActionResult IDCard(int id)
        {
            var student = _service.GetStudentById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

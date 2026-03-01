using Microsoft.AspNetCore.Mvc;
using mvc_ado.net.Data;

namespace mvc_ado.net.Controllers
{
    public class StudentController : Controller

    {
            private readonly StudentRepository _repo;

            public StudentController(StudentRepository repo)
            {
                _repo = repo;
            }

            public IActionResult Index()
            {
                var students = _repo.GetAllStudents();
            foreach(var i in students)
            {
                i.Square = i.Id * i.Id;
            }
                return View(students);
            }
       
        }
    }

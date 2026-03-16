using Microsoft.AspNetCore.Mvc;
using Postman.Models;
namespace Postman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var studets = new List<Student> {
                new Student { Id = 1, Name = "Shikha", Marks = 89 },
                new Student { Id = 2, Name = "Shi", Marks = 8 },
                new Student { Id = 3, Name = "kha", Marks = 9 },

            };
            return Ok(studets);
        }
        [HttpGet("add")]
        public IActionResult AddNumbers(int a, int b, int c)
        {
            int sum = a + b + c;
            return Ok(sum);
        }
        [HttpGet("even")]
        public IActionResult Even100()

        {
            int sum = 0;
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return Ok(sum);
        }

       


        public IActionResult Index()
        {
            return View();
        }
    }
}

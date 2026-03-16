using Microsoft.AspNetCore.Mvc;
using DTO.Models;
using DTO.DTO;
namespace DTO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>();

        // POST: api/student
        [HttpPost]
        public IActionResult CreateStudent(CreateStudentDTO request)
        {
            Student student = new Student
            {
                Id = students.Count + 1,
                Name = request.Name,
                Age = request.Age
               

            };

            students.Add(student);

            return Ok(student.Id);
        }

        // PUT: api/student
        [HttpPut]
        public IActionResult UpdateStudent(UpdateStudentDTO request)
        {
            var student = students.FirstOrDefault(s => s.Id == request.Id);

            if (student == null)
                return NotFound("Student not found");

            student.M1 = request.M1;
            student.M2 = request.M2;

            return Ok("Marks Updated");
        }
        // GET: api/student/result/1
        [HttpGet("result/{id}")]
        public IActionResult GetResultById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            int total = student.M1 + student.M2;

            char grade;
            if (total >= 180)
                grade = 'A';
            else if (total >= 150)
                grade = 'B';
            else if (total >= 100)
                grade = 'C';
            else
                grade = 'F';

            ResultDTO result = new ResultDTO
            {
                Id = student.Id,
                Name = student.Name,
                M1 = student.M1,
                M2 = student.M2,
                Total = total,
                Grade = grade
            };

            return Ok(result);
        }

        
    }
}

using Microsoft.AspNetCore.Mvc;
using ONEtoONEapi.Services;
using ONEtoONEapi.DTOS;
using ONEtoONEapi.Models;
namespace ONEtoONEapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost("addstudent")]
        public IActionResult AddStudent(AddStudent dto)
        {
            _service.AddStudent(dto);
            return Ok("Student Added");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _service.DeleteStudent(id);
            return Ok("Student Deleted");
        }

        [HttpPut("changeroom")]
        public IActionResult ChangeRoom(UpdateStudent dto)
        {
            _service.ChangeRoom(dto);
            return Ok("Room Updated");
        }
        [HttpGet("allstudents")]
        public IActionResult GetAllStudents()
        {
            var data = _service.GetAllStudents();
            return Ok(data);
        }

        [HttpGet("hostelstudents")]
        public IActionResult GetAllHostelStudents()
        {
            var data = _service.GetAllHostelStudents();
            return Ok(data);
        }

    }

        
    }


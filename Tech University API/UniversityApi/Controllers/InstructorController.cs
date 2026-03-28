using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructor _repo;

        public InstructorController(IInstructor repo)
        {
            _repo = repo;
        }
        [HttpPost("AddInstructor")]
        public IActionResult AddInstructor([FromBody] Instructor instructor)
        {
            if (instructor == null)
                return BadRequest("Invalid data");

            
            instructor.InstructorCourses ??= new List<InstructorCourse>();

            var result = _repo.AddInstructor(instructor);
            return result ? Ok() : BadRequest();
        }

        [HttpGet("WithCourseCountAbove/{count}")]
        public IActionResult GetByCount(int count)
        {
            var data = _repo.GetInstructorsWithCourseCountAbove(count);
            return data.Any() ? Ok(data) : NotFound("No Records Found");
        }

        [HttpGet("WithMostEnrollments")]
        public IActionResult GetTop()
        {
            var data = _repo.GetInstructorsWithMostEnrollments();
            return data.Any() ? Ok(data) : NotFound("No Records Found");
        }
    }
}

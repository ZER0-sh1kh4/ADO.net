using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _repo;

        public CourseController(ICourse repo)
        {
            _repo = repo;
        }
        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            if (course == null || course.CourseId <= 0)
                return BadRequest("Invalid data");

            var result = _repo.UpdateCourse(course);

            return result ? Ok("Updated successfully") : NotFound("Course not found");
        }

        [HttpGet("WithEnrollmentsAboveGrade/{grade}")]
        public IActionResult GetCourses(int grade)
        {
            var courses = _repo.GetCoursesWithEnrollmentsAboveGrade(grade);
            return courses.Any() ? Ok(courses) : NotFound("No Records Found");
        }

        [HttpGet("ByInstructorName/{instructorName}")]
        public IActionResult GetByInstructor(string instructorName)
        {
            var courses = _repo.GetCoursesByInstructorName(instructorName);
            return courses.Any() ? Ok(courses) : NotFound("No Records Found");
        }
    }
}

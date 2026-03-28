using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Interfaces;
using UniversityApi.Models;

namespace UniversityApi.Repositories
{
    public class InstructorRepository : IInstructor
    {
        private readonly UniversityContext _context;

        public InstructorRepository(UniversityContext context)
        {
            _context = context;
        }

        public bool AddInstructor(Instructor instructor)
        {
            if (_context.Instructors.Any(i => i.Name == instructor.Name))
                return false;

            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Instructor> GetInstructorsWithCourseCountAbove(int count)
        {
            return _context.InstructorCourses
                .GroupBy(ic => ic.Instructor)
                .Where(g => g.Count() > count)
                .Select(g => g.Key)
                .ToList();
        }

        public IEnumerable<Instructor> GetInstructorsWithMostEnrollments()
        {
            var data = _context.Instructors
                .Select(i => new
                {
                    Instructor = i,
                    EnrollmentCount = i.InstructorCourses
                        .SelectMany(ic => ic.Course.Enrollments)
                        .Count()
                })
                .ToList();

            int max = data.Max(x => x.EnrollmentCount);

            return data
                .Where(x => x.EnrollmentCount == max)
                .Select(x => x.Instructor)
                .ToList();
        }
    }
}

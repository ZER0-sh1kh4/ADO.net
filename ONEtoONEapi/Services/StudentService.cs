using Microsoft.EntityFrameworkCore;
using ONEtoONEapi.DTOS;
using ONEtoONEapi.Models;
namespace ONEtoONEapi.Services
{
    public class StudentService :IStudentService
    {
        private readonly OnetoOneApiContext _context;

        public StudentService(OnetoOneApiContext context)
        {
            _context = context;
        }

        public void AddStudent(AddStudent dto)
        {
            var hostel = _context.Hostels
        .FirstOrDefault(h => h.HostelId == dto.HostelId);

            if (hostel == null)
                throw new Exception("Hostel not found");

            var student = new Student
            {
                Name = dto.Name,
                HostelId = dto.HostelId
            };

            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
        public void ChangeRoom(UpdateStudent dto)
        {
            var student = _context.Students
                .Include(s => s.Hostel)
                .FirstOrDefault(s => s.StudentId == dto.StudentId);

            if (student != null)
            {
                student.Hostel.RoomNumber = dto.RoomNumber;
                _context.SaveChanges();
            }
        }
        public List<ViewAll> GetAllStudents()
        {
            var result = _context.Students
                .Include(s => s.Hostel)
                .Select(s => new ViewAll
                {
                    StudentId = s.StudentId,
                    Name = s.Name,
                    RoomNumber = s.Hostel.RoomNumber
                }).ToList();

            return result;
        }
        public List<ViewAll> GetAllHostelStudents()
        {
            var result = _context.Hostels
        .Include(h => h.Student)
        .Where(h => h.Student != null)
        .Select(h => new ViewAll
        {
            StudentId = h.Student.StudentId,
            Name = h.Student.Name,
            RoomNumber = h.RoomNumber
        }).ToList();

            return result;
        }
    }

}


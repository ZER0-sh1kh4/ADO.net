using Loginpage.Models;
using Loginpage.Data;
namespace Loginpage.Repositories
{
    public class StudentRepository :IStudentRepository
    {
        private readonly StudentDBContext _context;

        public StudentRepository(StudentDBContext context)
        {
            _context = context;
        }

        public Student Login(string name, string password)
        {
            return _context.Students
            .FirstOrDefault(s => s.Name == name && s.Password == password);
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }
        public List<Mark> GetMarks(int studentId)
        {
            return _context.Marks
            .Where(m => m.StudentId == studentId)
            .ToList();
        }
        
    }
}


using Loginpage.Models;
using Loginpage.Repositories;

namespace Loginpage.Services
{
    public class StudentService :IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public Student Login(string name, string password)
        {
            return _repo.Login(name, password);
        }

        public List<Mark> GetMarks(int studentId)
        {
            return _repo.GetMarks(studentId);
        }
        public Student GetStudentById(int id)
        {
            return _repo.GetStudentById(id);
        }
    }
}

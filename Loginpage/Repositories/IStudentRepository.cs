using Loginpage.Models;

namespace Loginpage.Repositories
{
    public interface IStudentRepository
    {
        Student Login(string name, string password);
        Student GetStudentById(int id);
        List<Mark> GetMarks(int studentId);
    }
}

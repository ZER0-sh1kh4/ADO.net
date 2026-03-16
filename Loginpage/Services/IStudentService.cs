using Loginpage.Models;

namespace Loginpage.Services
{
    public interface IStudentService
    {
        Student Login(string name, string password);
        Student GetStudentById(int id);
        List<Mark> GetMarks(int studentId);
    }
}

using Lab.Models;

namespace Lab.Services
{
    public interface IStudentServices
    {
        Task<List<Student>> SearchAsync(string q = null);
    }
}

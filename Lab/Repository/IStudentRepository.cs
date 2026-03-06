using Lab.Models;

namespace Lab.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync(string q = null);

    }
}

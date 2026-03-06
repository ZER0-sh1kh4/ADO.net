using Lab.Models;
using Lab.Repositories;
using Lab.Repository;
namespace Lab.Services
{
    public class StudentServices:IStudentServices
    {
        private readonly IStudentRepository _repo;
        public StudentServices(IStudentRepository repo)
        {
            _repo = repo;
        }
        public Task<List<Student>> SearchAsync(string q = null) => _repo.GetAllAsync(q);
    }
}

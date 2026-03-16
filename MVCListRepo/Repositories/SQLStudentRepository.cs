using MVCListRepo.Data;
using MVCListRepo.Models;
namespace MVCListRepo.Repositories
{
    public class SQLStudentRepository:IStudentRepository
    {
        private readonly AppDbContext context;

        public SQLStudentRepository(AppDbContext db)
        {
            context = db;
        }

        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}

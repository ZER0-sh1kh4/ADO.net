using Loginpage.Models;
using Microsoft.EntityFrameworkCore;
namespace Loginpage.Data
{
    public class StudentDBContext :DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }

    }
}

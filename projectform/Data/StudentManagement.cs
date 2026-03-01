
using projectform.Models;
using Microsoft.EntityFrameworkCore;

namespace projectform.Data
{
    public class StudentManagement : DbContext
    {
        public StudentManagement(DbContextOptions<StudentManagement> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
       // public DbSet<Hostel> Hostels { get; set; }



    }
}
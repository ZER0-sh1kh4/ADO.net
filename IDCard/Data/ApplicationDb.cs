using Microsoft.EntityFrameworkCore;
using IDCard.Models;

namespace IDCard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CollegeApplication> CollegeApplications { get; set; }
    }
}
using JWTOneToOne.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTOneToOne.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<CollegeAdmission> Admissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(u => u.CollegeAdmission)
            .WithOne(a => a.User)
            .HasForeignKey<CollegeAdmission>(a => a.UserId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Paging.Models;
namespace Paging.Data
{
    public class DataDb :DbContext
    {
        public DataDb(DbContextOptions<DataDb> options)
           : base(options)
        {
        }
        public DbSet<Paging.Models.Datab> Datab { get; set; } = default!;
    }
}

using AdvancedProgramming_Lesson2.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson2.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}

using AdvancedProgramming_Lesson2.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson2.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}

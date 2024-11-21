using AbrarHamdy_S1.Models;
using Microsoft.EntityFrameworkCore;

namespace AbrarHamdy_S1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
    }
}

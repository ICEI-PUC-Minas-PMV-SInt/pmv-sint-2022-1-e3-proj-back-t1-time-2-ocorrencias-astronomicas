using Microsoft.EntityFrameworkCore;
using AstroCal.Models;

namespace AstroCal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<AstroCal.Models.Galeria> Galeria { get; set; }

    }
}

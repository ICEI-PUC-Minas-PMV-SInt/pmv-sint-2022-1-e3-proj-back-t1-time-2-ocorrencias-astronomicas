using Microsoft.EntityFrameworkCore;

namespace api_projeto_astrocal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}

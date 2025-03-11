using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Agrega las propiedades DbSet para tus entidades aquí
        // public DbSet<TuEntidad> TuEntidades { get; set; }
    }
}

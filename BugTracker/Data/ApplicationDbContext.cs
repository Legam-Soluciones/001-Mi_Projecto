using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        // ✅ Mueve la declaración de DbSet fuera del constructor
        public DbSet<User> Users { get; set; }
    }
}

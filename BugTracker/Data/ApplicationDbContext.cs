using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }  // 🔹 Asegurar que esté definido
        public DbSet<Comment> Comments { get; set; }
    }
}

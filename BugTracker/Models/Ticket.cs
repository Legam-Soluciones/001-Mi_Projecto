using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Models  // ✅ Asegúrate de que sea el mismo en todos los modelos
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";
        public int UserId { get; set; }
        public required User User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}

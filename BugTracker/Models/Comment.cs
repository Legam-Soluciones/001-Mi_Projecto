using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }  // ✅ Permitir que Ticket sea null
        public int UserId { get; set; }
        public User? User { get; set; }  // ✅ Permitir que User sea null
        public string CommentText { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

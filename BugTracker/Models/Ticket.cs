namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";
        public int UserId { get; set; }
        public User? User { get; set; }  // ✅ Permitir que User sea null

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}

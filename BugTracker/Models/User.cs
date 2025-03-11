namespace BugTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;  // ✅ Evita valores nulos
        public string Email { get; set; } = string.Empty;  // ✅ Evita valores nulos
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}

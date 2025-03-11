namespace BugTracker.Models
{
    public class User
    {
        public int Id { get; set; }  // Clave primaria
        public required string Name { get; set; }  // Nombre de usuario
        public required string Email { get; set; } // Correo electrónico
    }
}

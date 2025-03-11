using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Controllers
{
    [Route("api/[controller]")]  // ✅ Define la ruta como "/api/tickets"
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/tickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        // ✅ POST: api/tickets
        [HttpPost]
        public async Task<IActionResult> CreateTicket([FromBody] Ticket ticket)
        {
            if (ticket == null || string.IsNullOrEmpty(ticket.Title) || string.IsNullOrEmpty(ticket.Description))
            {
                return BadRequest("Todos los campos son obligatorios.");
            }

            // Verificar si el usuario existe en la base de datos
            var userExists = await _context.Users.FindAsync(ticket.UserId);
            if (userExists == null)
            {
                return BadRequest("El usuario no existe.");
            }

            // Asegurar que no haya conflicto con Entity Framework (detachear user)
            ticket.User = null;

            // Agregar y guardar en la base de datos
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTickets), new { id = ticket.Id }, ticket);
            try
            {
                _context.Tickets.Add(ticket);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al guardar en la base de datos: {ex.Message}");
            }

        }
    }
}


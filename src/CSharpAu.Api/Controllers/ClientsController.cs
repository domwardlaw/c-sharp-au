using CSharpAu.Api.Data;
using CSharpAu.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpAu.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase {
    private readonly ApplicationDbContext _context;

    public ClientsController(ApplicationDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetAllClients() => Ok(await _context.Clients.OrderBy(c => c.DisplayOrder).ToListAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClient(int id) {
        var client = await _context.Clients.FindAsync(id);
        return client == null ? NotFound() : Ok(client);
    }
}
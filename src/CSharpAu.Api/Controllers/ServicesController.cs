using CSharpAu.Api.Data;
using CSharpAu.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpAu.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController : ControllerBase {
    private readonly ApplicationDbContext _context;

    public ServicesController(ApplicationDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Service>>> GetAllServices() => Ok(await _context.Services.OrderBy(s => s.DisplayOrder).ToListAsync());

    [HttpGet("categories")]
    public async Task<ActionResult<IEnumerable<string>>> GetCategories() => Ok(await _context.Services.Select(s => s.Category).Distinct().OrderBy(c => c).ToListAsync());

    [HttpGet("category/{category}")]
    public async Task<ActionResult<IEnumerable<Service>>> GetServicesByCategory(string category) => Ok(await _context.Services.Where(s => s.Category == category).OrderBy(s => s.DisplayOrder).ToListAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Service>> GetService(int id) {
        var service = await _context.Services.FindAsync(id);
        return service == null ? NotFound() : Ok(service);
    }
}
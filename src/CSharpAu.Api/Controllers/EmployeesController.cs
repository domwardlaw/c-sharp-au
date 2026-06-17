using CSharpAu.Api.Data;
using CSharpAu.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpAu.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase {
    private readonly ApplicationDbContext _context;

    public EmployeesController(ApplicationDbContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees() => Ok(await _context.Employees.OrderBy(e => e.Name).ToListAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id) {
        var employee = await _context.Employees.FindAsync(id);
        return employee == null ? NotFound() : Ok(employee);
    }
}
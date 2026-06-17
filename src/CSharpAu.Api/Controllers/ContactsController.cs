using CSharpAu.Api.Models;
using CSharpAu.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharpAu.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase {
    private readonly IContactService _contactService;
    private readonly ILogger<ContactsController> _logger;

    public ContactsController(IContactService contactService, ILogger<ContactsController> logger) {
        _contactService = contactService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<ActionResult<Contact>> CreateContact([FromBody] CreateContactDto dto) {
        try {
            var contact = await _contactService.CreateContactAsync(dto);
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        } catch (Exception ex) {
            _logger.LogError($"Error: {ex.Message}");
            return BadRequest();
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> GetContact(int id) {
        var contact = await _contactService.GetContactByIdAsync(id);
        return contact == null ? NotFound() : Ok(contact);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contact>>> GetAllContacts() => Ok(await _contactService.GetAllContactsAsync());

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(int id) {
        var result = await _contactService.DeleteContactAsync(id);
        return result ? NoContent() : NotFound();
    }
}
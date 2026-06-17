using CSharpAu.Api.Data;
using CSharpAu.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpAu.Api.Services;

public class ContactService : IContactService {
    private readonly ApplicationDbContext _context;
    private readonly IEmailService _emailService;
    private readonly ILogger<ContactService> _logger;

    public ContactService(ApplicationDbContext context, IEmailService emailService, ILogger<ContactService> logger) {
        _context = context;
        _emailService = emailService;
        _logger = logger;
    }

    public async Task<Contact> CreateContactAsync(CreateContactDto dto) {
        var contact = new Contact { Name = dto.Name, Email = dto.Email, Message = dto.Message, CreatedAt = DateTime.UtcNow };
        _context.Contacts.Add(contact);
        await _context.SaveChangesAsync();
        var emailSent = await _emailService.SendContactNotificationAsync(dto.Name, dto.Email, dto.Message);
        if (emailSent) contact.Status = "Email Sent";
        _logger.LogInformation($"Contact created: {contact.Id}");
        return contact;
    }

    public async Task<Contact?> GetContactByIdAsync(int id) => await _context.Contacts.FindAsync(id);
    public async Task<IEnumerable<Contact>> GetAllContactsAsync() => await _context.Contacts.OrderByDescending(c => c.CreatedAt).ToListAsync();
    
    public async Task<bool> DeleteContactAsync(int id) {
        var contact = await _context.Contacts.FindAsync(id);
        if (contact == null) return false;
        _context.Contacts.Remove(contact);
        await _context.SaveChangesAsync();
        return true;
    }
}
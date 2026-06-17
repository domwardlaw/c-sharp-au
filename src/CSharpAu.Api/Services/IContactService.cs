using CSharpAu.Api.Models;

namespace CSharpAu.Api.Services;

public interface IContactService {
    Task<Contact> CreateContactAsync(CreateContactDto dto);
    Task<Contact?> GetContactByIdAsync(int id);
    Task<IEnumerable<Contact>> GetAllContactsAsync();
    Task<bool> DeleteContactAsync(int id);
}
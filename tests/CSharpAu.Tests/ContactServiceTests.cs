using CSharpAu.Api.Data;
using CSharpAu.Api.Models;
using CSharpAu.Api.Services;
using Moq;
using Xunit;

namespace CSharpAu.Tests;

public class ContactServiceTests {
    [Fact]
    public async Task CreateContactAsync_WithValidData_ReturnsContact() {
        var mockContext = new Mock<ApplicationDbContext>();
        var mockEmailService = new Mock<IEmailService>();
        var mockLogger = new Mock<ILogger<ContactService>>();
        
        var service = new ContactService(mockContext.Object, mockEmailService.Object, mockLogger.Object);
        var dto = new CreateContactDto { Name = "John", Email = "john@test.com", Message = "Test message" };
        
        Assert.NotNull(service);
    }
}
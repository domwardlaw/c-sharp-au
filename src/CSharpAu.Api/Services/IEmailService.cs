namespace CSharpAu.Api.Services;
public interface IEmailService {
    Task<bool> SendEmailAsync(string to, string subject, string body, bool isHtml = true);
    Task<bool> SendContactNotificationAsync(string name, string email, string message);
}
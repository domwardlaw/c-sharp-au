using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace CSharpAu.Api.Services;

public class EmailService : IEmailService {
    private readonly IConfiguration _configuration;
    private readonly ILogger<EmailService> _logger;

    public EmailService(IConfiguration configuration, ILogger<EmailService> logger) {
        _configuration = configuration;
        _logger = logger;
    }

    public async Task<bool> SendEmailAsync(string to, string subject, string body, bool isHtml = true) {
        try {
            var smtpSettings = _configuration.GetSection("Smtp");
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("C# Australia", smtpSettings["From"]));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;
            
            var bodyBuilder = new BodyBuilder();
            if (isHtml) bodyBuilder.HtmlBody = body;
            else bodyBuilder.TextBody = body;
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient()) {
                await client.ConnectAsync(smtpSettings["Server"], int.Parse(smtpSettings["Port"] ?? "587"), SecureSocketOptions.StartTls);
                if (!string.IsNullOrEmpty(smtpSettings["Username"])) {
                    await client.AuthenticateAsync(smtpSettings["Username"], smtpSettings["Password"]);
                }
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            
            _logger.LogInformation($"Email sent to {to}");
            return true;
        } catch (Exception ex) {
            _logger.LogError($"Error sending email: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> SendContactNotificationAsync(string name, string email, string message) {
        var adminEmail = _configuration["ContactEmail"] ?? "admin@c-sharp.au";
        var htmlBody = $"<h2>New Contact</h2><p><strong>Name:</strong> {name}</p><p><strong>Email:</strong> {email}</p><p><strong>Message:</strong> {message}</p>";
        return await SendEmailAsync(adminEmail, "New Contact Form", htmlBody, true);
    }
}
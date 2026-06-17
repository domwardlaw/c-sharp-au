namespace CSharpAu.Api.Models;
public class Contact {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Message { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? Status { get; set; } = "New";
    public string? Notes { get; set; }
}
namespace CSharpAu.Api.Models;
public class Employee {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Position { get; set; }
    public required string Bio { get; set; }
    public string? PhotoUrl { get; set; }
    public string? Email { get; set; }
}
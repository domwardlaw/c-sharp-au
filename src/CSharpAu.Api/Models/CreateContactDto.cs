namespace CSharpAu.Api.Models;
public class CreateContactDto {
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Message { get; set; }
}
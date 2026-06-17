namespace CSharpAu.Api.Models;
public class Client {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Location { get; set; }
    public required string Country { get; set; }
    public string? Logo { get; set; }
    public int DisplayOrder { get; set; }
}
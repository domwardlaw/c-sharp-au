namespace CSharpAu.Api.Models;
public class Service {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public required string Description { get; set; }
    public int DisplayOrder { get; set; }
}
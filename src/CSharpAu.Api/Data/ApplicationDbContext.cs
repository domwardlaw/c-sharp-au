using CSharpAu.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpAu.Api.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Client>().HasData(
            new Client { Id = 1, Name = "University of New South Wales", Location = "Sydney", Country = "Australia", DisplayOrder = 1 },
            new Client { Id = 2, Name = "Commonwealth Bank", Location = "Sydney", Country = "Australia", DisplayOrder = 2 }
        );
        
        modelBuilder.Entity<Service>().HasData(
            new Service { Id = 1, Name = "C#", Category = "Languages", Description = "Enterprise programming", DisplayOrder = 1 },
            new Service { Id = 2, Name = "Microsoft Azure", Category = "Cloud", Description = "Cloud solutions", DisplayOrder = 2 }
        );
        
        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "John Smith", Position = "Senior Developer", Bio = "20+ years experience", Email = "john@c-sharp.au" }
        );
    }
}
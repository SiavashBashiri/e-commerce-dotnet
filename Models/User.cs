using Microsoft.AspNetCore.Identity;

namespace e_commerce.Models;

public class User : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // ToDo: uncomment after creating Order Model
    // public ICollection<Order> Orders { get; set; } = new List<Orders>();
}

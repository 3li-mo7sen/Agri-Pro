using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(120)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(160)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public UserRole Role { get; set; }

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    [MaxLength(160)]
    public string? Location { get; set; }

    public ICollection<Project> Projects { get; set; } = new List<Project>();
    public ICollection<Investment> Investments { get; set; } = new List<Investment>();
    public ICollection<Product> Products { get; set; } = new List<Product>();
}

public enum UserRole
{
    Farmer = 1,
    Investor = 2,
    Buyer = 3,
    Admin = 4
}

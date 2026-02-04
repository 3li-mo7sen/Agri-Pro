using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class Product
{
    public int Id { get; set; }

    public int FarmerId { get; set; }
    public User? Farmer { get; set; }

    [Required]
    [MaxLength(140)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(120)]
    public string Category { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    [Range(0, double.MaxValue)]
    public decimal PricePerUnit { get; set; }

    [Range(0, double.MaxValue)]
    public decimal QuantityAvailable { get; set; }

    public ProductStatus Status { get; set; } = ProductStatus.PendingReview;

    [MaxLength(120)]
    public string? Region { get; set; }

    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
    public ICollection<ProductReport> Reports { get; set; } = new List<ProductReport>();
}

public enum ProductStatus
{
    PendingReview = 1,
    Approved = 2,
    Blocked = 3,
    Archived = 4
}

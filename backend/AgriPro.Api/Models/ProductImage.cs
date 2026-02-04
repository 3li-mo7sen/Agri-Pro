using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class ProductImage
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [Required]
    [MaxLength(300)]
    public string Url { get; set; } = string.Empty;
}

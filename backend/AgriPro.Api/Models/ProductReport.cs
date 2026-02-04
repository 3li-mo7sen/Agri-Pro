using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class ProductReport
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [Required]
    [MaxLength(500)]
    public string Reason { get; set; } = string.Empty;

    public ReportStatus Status { get; set; } = ReportStatus.Pending;

    public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
}

public enum ReportStatus
{
    Pending = 1,
    Reviewed = 2,
    Dismissed = 3
}

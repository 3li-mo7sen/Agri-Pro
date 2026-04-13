using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class Investment
{
    public int Id { get; set; }

    public int InvestorId { get; set; }
    public User? Investor { get; set; }

    public int ProjectId { get; set; }
    public Project? Project { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [MaxLength(200)]
    public string? Notes { get; set; }

    public DateTime InvestedAt { get; set; } = DateTime.UtcNow;
}

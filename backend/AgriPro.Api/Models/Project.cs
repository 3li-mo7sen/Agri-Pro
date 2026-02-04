using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class Project
{
    public int Id { get; set; }

    [Required]
    [MaxLength(140)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [MaxLength(120)]
    public string CropType { get; set; } = string.Empty;

    public decimal TargetBudget { get; set; }
    public decimal CurrentFunding { get; set; }

    [MaxLength(120)]
    public string Location { get; set; } = string.Empty;

    public ProjectStatus Status { get; set; } = ProjectStatus.PendingApproval;

    public int FarmerId { get; set; }
    public User? Farmer { get; set; }

    public ICollection<Investment> Investments { get; set; } = new List<Investment>();
    public ICollection<FarmTask> Tasks { get; set; } = new List<FarmTask>();
    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}

public enum ProjectStatus
{
    PendingApproval = 1,
    Active = 2,
    Completed = 3,
    OnHold = 4
}

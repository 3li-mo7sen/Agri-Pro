using System.ComponentModel.DataAnnotations;

namespace AgriPro.Api.Models;

public class FarmTask
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public Project? Project { get; set; }

    [Required]
    [MaxLength(160)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public DateTime DueDate { get; set; }

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
}

public enum TaskStatus
{
    Pending = 1,
    InProgress = 2,
    Done = 3
}

namespace M3alemAPI.Models;

public class Job
{
    public int Id { get; set; }

    public int ConsumerId { get; set; }
    public int? WorkerId { get; set; }

    public string? Description { get; set; }
    public string? Location { get; set; }

    public string Status { get; set; } = "pending"; // pending / assigned / completed

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User Consumer { get; set; } = null!;
    public User? Worker { get; set; }
}

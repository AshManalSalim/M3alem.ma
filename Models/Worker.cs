namespace M3alemAPI.Models;

public class Worker
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public string? Category { get; set; }
    public decimal Rating { get; set; } = 0;
    public int JobsCompleted { get; set; } = 0;

    public User User { get; set; } = null!;
}

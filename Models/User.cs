namespace M3alemAPI.Models;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public string Role { get; set; } = "consumer"; // "worker" or "consumer"
    public string? Location { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Worker? WorkerProfile { get; set; }
    public ICollection<Job>? JobsRequested { get; set; }
    public ICollection<Job>? JobsAssigned { get; set; }
    public ICollection<Rating>? RatingsGiven { get; set; }
}

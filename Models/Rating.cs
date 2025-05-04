namespace M3alemAPI.Models;

public class Rating
{
    public int Id { get; set; }

    public int JobId { get; set; }
    public int RatedById { get; set; }

    public int RatingValue { get; set; } // 1 to 5
    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Job Job { get; set; } = null!;
    public User RatedBy { get; set; } = null!;
}

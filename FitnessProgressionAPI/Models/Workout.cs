using System.ComponentModel.DataAnnotations;

public class Workout
{
    public int Id { get; set; }

    public DateTime WorkoutDate { get; set; }

    public TimeSpan Length { get; set; }

    [MaxLength(100)]
    public string Notes { get; set; } = "";

    [MaxLength(100)]
    public string Type { get; set; } = "";

    public int UserId { get; set; }

    public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
}
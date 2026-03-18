public class Workout
{
    public int Id { get; set; }
    public DateTime WorkoutDate { get; set; }
    public TimeSpan Length { get; set; }
    public string Notes { get; set; } = "";
    public string Type { get; set; } = "";
    public int UserId { get; set; }
    public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
}
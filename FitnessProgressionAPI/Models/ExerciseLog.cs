public class ExerciseLog
{
    public int Id { get; set; }
    public int ExerciseId { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public decimal Weight { get; set; }
    public int RestSeconds { get; set; }
    public int WorkoutId { get; set; }
}
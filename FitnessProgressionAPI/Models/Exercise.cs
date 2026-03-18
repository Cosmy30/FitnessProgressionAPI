public class Exercise
{
    public int Id { get; set; }
    public string Category { get; set; } = "";
    public int DifficultyLevel { get; set; }
    public string Family { get; set; } = "";
    public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
}
namespace FitnessProgressionAPI.DTOs.ExerciseLogs
{
    public class ExerciseLogResponseDto
    {
        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public string ExerciseName { get; set; } = null!;

        public int Sets { get; set; }

        public int Reps { get; set; }

        public decimal Weight { get; set; }

        public int RestSeconds { get; set; }
    }
}

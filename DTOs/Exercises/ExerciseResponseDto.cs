using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.DTOs.Exercises
{
    public class ExerciseResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public ExerciseCategory Category { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public string Family { get; set; } = null!;
    }
}

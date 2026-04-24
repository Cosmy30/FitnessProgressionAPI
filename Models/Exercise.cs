using System.ComponentModel.DataAnnotations;

namespace FitnessProgressionAPI.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        [MaxLength(100)]
        public string Category { get; set; } = "";

        public int DifficultyLevel { get; set; }

        [MaxLength(100)]
        public string Family { get; set; } = "";

        public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
    }
}

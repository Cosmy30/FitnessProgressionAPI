using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessProgressionAPI.Models
{
    public class ExerciseLog
    {
        public int Id { get; set; }

        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; } = null!;

        public int Sets { get; set; }

        public int Reps { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Weight { get; set; }

        public int RestSeconds { get; set; }

        public int WorkoutId { get; set; }

        public Workout Workout { get; set; } = null!;
    }
}

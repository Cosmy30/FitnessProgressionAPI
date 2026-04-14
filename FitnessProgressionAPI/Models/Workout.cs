using System.ComponentModel.DataAnnotations;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.Models
{
    public class Workout
    {
        public int Id { get; set; }

        public DateTime WorkoutDate { get; set; }

        public int DurationMinutes { get; set; }

        [MaxLength(100)]
        public string Notes { get; set; } = "";

        public WorkoutType Type { get; set; }

        public int UserId { get; set; }

        public List<ExerciseLog> ExerciseLogs { get; set; } = new List<ExerciseLog>();
    }
}

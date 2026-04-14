using System.ComponentModel.DataAnnotations;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.DTOs.Workouts
{
    public class CreateWorkoutDto
    {
        public int DurationMinutes { get; set; }

        [StringLength(1000)]
        public string? Notes { get; set; }

        public WorkoutType Type { get; set; }
    }
}
